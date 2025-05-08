using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    // Restarts the level
    public void Restart()
    {
        SceneManager.LoadSceneAsync("BaseLevel");
        Time.timeScale = 1f;
    }
    
    // Sends the player to the Main Menu
    public void Mainmenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
        Time.timeScale = 1f;
    }

}
