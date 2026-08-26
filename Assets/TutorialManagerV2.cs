using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TutorialManagerV2 : MonoBehaviour
{
    [Header("Screen Setup")]
    public MeshRenderer quadRenderer; // Drag your Instruction_Display here
    public Texture welcomeTexture;    // Drag your Welcome UI image here
    public List<Texture> instructionSlides; // Drag image 5, 6, and 8 here

    [Header("Buttons")]
    public GameObject exitButton; // The Green Button

    private int currentSlideIndex = -1; // -1 means we are on the Welcome screen

    void Start()
    {
        // Set the screen to the Welcome UI immediately
        quadRenderer.material.mainTexture = welcomeTexture;
        
        // Hide the Exit button at the start
        if(exitButton != null) exitButton.SetActive(false);
    }

    // Connect this to the RED BUTTON
    public void HandleNextAction()
    {
        currentSlideIndex++;

        if (currentSlideIndex < instructionSlides.Count)
        {
            // Swap the texture to the next instruction
            quadRenderer.material.mainTexture = instructionSlides[currentSlideIndex];
        }
        else
        {
            // If we finish all slides, show a "Finished" message or texture
            // and reveal the Green Exit button
            Debug.Log("Tutorial Finished!");
            if(exitButton != null) exitButton.SetActive(true);
        }
    }

    // Connect this to the GREEN BUTTON
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Use your actual Main Menu scene name
    }
}