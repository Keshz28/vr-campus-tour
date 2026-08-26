using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}


