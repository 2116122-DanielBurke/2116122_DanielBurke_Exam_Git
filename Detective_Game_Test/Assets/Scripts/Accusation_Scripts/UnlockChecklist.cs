using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockChecklist : MonoBehaviour
{
    public Unlock_Manager UM;
    public GameObject GO1, GO2, GO3, GO4, GO5, GO6, GO7, GO8, GO9, GO10;
    void Start()
    {
        UM = FindObjectOfType<Unlock_Manager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (UM.unlock01)
        {
            GO1.SetActive(true);
        }
        if (UM.unlock02)
        {
            GO2.SetActive(true);
        }
        if (UM.unlock03)
        {
            GO3.SetActive(true);
        }
        if (UM.unlock04)
        {
            GO4.SetActive(true);
        }
        if (UM.unlock05)
        {
            GO5.SetActive(true);
        }
        if (UM.unlock06)
        {
            GO6.SetActive(true);
        }
        if (UM.unlock07)
        {
            GO7.SetActive(true);
        }
        if (UM.unlock08)
        {
            GO8.SetActive(true);
        }
        if (UM.unlock09)
        {
            GO9.SetActive(true);
        }
        if (UM.unlock10)
        {
            GO10.SetActive(true);
        }
    }
}
