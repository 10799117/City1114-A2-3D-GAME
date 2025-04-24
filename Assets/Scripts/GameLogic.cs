using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Counter.GetComponent<Text>().text = Counter + "/5";

    }
}