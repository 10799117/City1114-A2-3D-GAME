using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLogic : MonoBehaviour
{
    // Identifies counter object
    public GameObject Counter;

    public int bloodvialCount;

    public GameObject Endscreen;

    public void BloodvialIncrease()
    {
        // Add to counter total
        bloodvialCount += 1;

        // Sets Enscreen as active when the last vial is picked up
        if (bloodvialCount == 5)
        {
            Endscreen.SetActive(true);
            // Pauses the game
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void Start()
    {
        // Start the counter at 0
        bloodvialCount = 0;

    }



    void Update()
    {
        // Display counter text with /5  with every item pickup
        Counter.GetComponent<TextMeshProUGUI>().text = bloodvialCount + "/5";

    }
}