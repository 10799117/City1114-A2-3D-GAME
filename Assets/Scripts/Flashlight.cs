using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    // Different Flashlight States
    private bool on;
    private bool off;


    // Ensures the flashlight is off when the scene is loaded
    void Start()
    {
        off = true;
        flashlight.SetActive(false);
    }


    // Detects input to turn the flashlight on/off
    void Update()
    {
        // turns flashlight on
        if (off && Input.GetButtonDown("flashlight"))
        {
            flashlight.SetActive(true);
            off = false;
            on = true;
        }
        // turns flashlight off
        else if (on && Input.GetButtonDown("flashlight"))
        {
            flashlight.SetActive(false);
            off = true;
            on = false;
       
        }

    }

}
