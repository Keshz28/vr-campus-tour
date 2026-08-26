using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class QuadInstruction : MonoBehaviour
{
    [Header("References")]
    public MeshRenderer displayRenderer; // Drag your Quad here
    public List<Texture> tutorialImages; // Drag your 3 images here
    public GameObject practiceButton; // The red button on the table
    public GameObject exitButton; // The button that leads back to menu

    private int currentIndex = 0;

    void Start()
    {
        // Start with the first image (Equipment Guide)
        if (tutorialImages.Count > 0)
            displayRenderer.material.mainTexture = tutorialImages[0];
        
        practiceButton.SetActive(false); // Hide practice button until images are done
        exitButton.SetActive(false); // Hide exit button until tutorial is complete
    }

    public void NextSlide()
    {
        currentIndex++;

        if (currentIndex < tutorialImages.Count)
        {
            displayRenderer.material.mainTexture = tutorialImages[currentIndex];
        }
        else
        {
            displayRenderer.gameObject.SetActive(false); 
            practiceButton.SetActive(true); 
            Debug.Log("Please walk to the table and press the red button.");
        }
    }

    public void CompleteTutorial()
    {
        practiceButton.SetActive(false);
        exitButton.SetActive(true); 
        Debug.Log("Tutorial Complete!");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
