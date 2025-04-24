using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject collectText;

    public bool inReach;

    private GameObject Bloodvial;

    private void Start()
    {
        collectText.SetActive(false);

        inReach = false;

        Bloodvial = this.gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            collectText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == collectText)
        {
            inReach = false;
            collectText.SetActive(false);
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Pickup"))

        {
            collectText.SetActive(false);
            Bloodvial.SetActive(false);
            inReach = false;
        }
    }
}
