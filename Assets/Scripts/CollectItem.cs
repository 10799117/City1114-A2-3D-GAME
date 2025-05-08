using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject collectText;

    // Refers to the Reach Tool
    public bool inReach;

    // Calls to asset
    private GameObject Bloodvial;

    // Calls to Game Logic Script
    private GameObject gameLogic;

    private void Start()
    {
       // Ensures the text doesnt display when scene is loaded
        collectText.SetActive(false);

        inReach = false;

        gameLogic = GameObject.FindWithTag("GameLogic");

        Bloodvial = this.gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        // If the Asset is in reach (via reach tool)
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            // Display the Collection Text 
            collectText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == collectText)
        {
            inReach = false;
            // Don't display the text when not in reach 
            collectText.SetActive(false);
        }
    }

    void Update()
    {
        // If the player interacts with the asset
        if (inReach && Input.GetButtonDown("Pickup"))

        {


            // Add to counter total
            gameLogic.GetComponent<GameLogic>().BloodvialIncrease();
            // Remove Text from scene
            collectText.SetActive(false);
            // Remove Asset from scene
            Bloodvial.SetActive(false);
            inReach = false;
        }
    }
}
