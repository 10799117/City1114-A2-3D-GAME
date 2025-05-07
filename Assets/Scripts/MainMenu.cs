using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Loads Scene
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("BaseLevel");

    }

    // Quits Game
    public void QuitGame()
    {
        Application.Quit();
    }
}

