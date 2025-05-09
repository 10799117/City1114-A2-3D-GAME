using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    // Makes sure the game doesn't load with the menu open
    void Start()
    {
        pauseMenu.SetActive(false);
    }

   // Activates Menu when paused
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

 
    public void PauseGame()
    {
        // Pauses the game in the background
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

  
    public void ResumeGame()
    {
        // Unpauses the game in the background
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MainMenu()
    {
        // Loads the main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

  
    public void QuitGame()
    {
        // Quits the game
        Application.Quit();
        Debug.Log("The application has quit.");
    }
}

