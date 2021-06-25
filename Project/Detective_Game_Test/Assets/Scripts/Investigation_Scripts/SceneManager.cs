using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.FindGameObjectsWithTag("EvidenceButton");
        foreach(GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = false;
            if(button.GetComponent<Image>() != null)
            button.GetComponent<Image>().enabled = false;
            else if(button.GetComponentInChildren<TextMeshProUGUI>() != null)
            button.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
