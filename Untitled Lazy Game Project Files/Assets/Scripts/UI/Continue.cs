using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //load the tutorial scence
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene("TutorialScreen", LoadSceneMode.Single); //load the tutorial scence
    }

    public void ExitGame()
    {
        Application.Quit(); // Exit the application
    }
}
