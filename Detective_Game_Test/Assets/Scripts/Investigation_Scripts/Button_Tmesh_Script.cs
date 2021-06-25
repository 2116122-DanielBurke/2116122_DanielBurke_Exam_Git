using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using System.IO;

public class Button_Tmesh_Script : MonoBehaviour
{
    public GameObject parent;
    
    [SerializeField] string outputString;
    Image image;
    Button button;
    public GameObject eListPrefabGO;
    GameObject eList;
    public Transform contentView;
    [SerializeField] bool isFilled = false;
    Text dialogueText /*eListText*/;
    string buttonString;
    void Start()
    {
        dialogueText = GameObject.Find("DialogueText").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    public void Evidence_Button()
    {
        ButtonString();
        Debug.Log(buttonString);
       eList = Instantiate(eListPrefabGO, contentView);
        eList.GetComponent<Text>().text = "• " + buttonString;
        StartCoroutine(NewEvidence());
        DisableItem();
        DisableButton();        
    }

   void ButtonString()
    {
       string tempstring = null;
       tempstring = outputString;
       buttonString = tempstring;
    }

    void DisableItem()
    {        
        Debug.Log(parent.name);
        parent.tag = "Untagged";
        DisableButton();
    }
    void DisableButton()
    {
        button = parent.GetComponentInChildren<Button>();
        image = button.GetComponent<Image>();
        Debug.Log(button + "button to disable");
        image.enabled = false;
        button.enabled = false;
        button = null;
        image = null;
    }

    
    IEnumerator NewEvidence()
    {
        dialogueText.text = "A new item has been added to your list.";
        yield return new WaitForSeconds(1.5f);
        dialogueText.text = "";
    }
}
