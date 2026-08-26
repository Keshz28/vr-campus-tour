using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GoToTutorial() => SceneManager.LoadScene("TutorialScene");
    public void GoToTour() => SceneManager.LoadScene("MainTourScene");
}