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