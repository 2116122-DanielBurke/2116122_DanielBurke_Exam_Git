using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public GameObject evidenceListGO;
    
    Button button;
    
    Image image;
    bool isFilled;
    
    
   

   public Text dialogueText;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    public void ItemButton()
    {
        StartCoroutine(_Item());
        if (EventSystem.current.currentSelectedGameObject.name == "Item_Button")
        {
            GameObject t = FindParentWithTag(button.GetComponent<Button>(), "Selectable");
            DisableItem();
        }
        else
        {
            DisableButton();
        }
    }
    public void DisableItem()
    {
        GameObject t = FindParentWithTag(EventSystem.current.currentSelectedGameObject.GetComponent<Button>(), "Selectable");
        Debug.Log(t.name + "clicked on cardboard box");
        t.tag = "Untagged";
        DisableButton();
    }    public void DisableButton()
    {
        button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        Debug.Log(button + "button to disable");
        
        image = button.GetComponentInChildren<Image>();
        image.enabled = false;
        button.enabled = false;
        button = null;
        image = null;
        
    }
    
    
    IEnumerator _Item()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Shelf_Handprint")
            dialogueText.text = "A greasy handprint atop a shelf.";
        if (EventSystem.current.currentSelectedGameObject.name == "Handprint_Doughnut03")        
            dialogueText.text = "A handprint covered doughnut box, now empty.";
       
        if (EventSystem.current.currentSelectedGameObject.name == "Fingerprint_Doughnut01")
            dialogueText.text = "A mostly fresh box of doughnuts, already covered in greedy handprints.";
        yield return new WaitForSeconds(4f);
        dialogueText.text = "";


    }
    public static GameObject FindParentWithTag(Button childObject, string tag)
    {
        Transform t = childObject.transform;
        while (t.parent != null)
        {
            if (t.parent.tag == tag)
            {
                return t.parent.gameObject;
            }
            t = t.parent.transform;
            
        }
        return null; // Could not find a parent with given tag.
        
    }



}
