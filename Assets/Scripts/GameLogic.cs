using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public GameObject Counter;

    private int bloodvialCount;


    void Start()
    {
        bloodvialCount = 0;

    }



    void Update()
    {
        Counter.GetComponent<TextMeshProUGUI>().text = bloodvialCount + "/5";

    }
}