using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Manager : MonoBehaviour
{
    GameObject[] callDetailButtons;

    private void Start()
    {
        callDetailButtons = GameObject.FindGameObjectsWithTag("CallDetailButton");


    }

    public void Call()
    {
        foreach(GameObject button in callDetailButtons)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }
    public void EndCall()
    {
        foreach (GameObject button in callDetailButtons)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
}
