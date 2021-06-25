using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class OpenContainer : MonoBehaviour
{
    public GameObject parent;
    Button button;
    Image image;
    
    [SerializeField] GameObject[] GO;
    
    // Start is called before the first frame update
    void Start()
    {

        foreach (GameObject go in GO)
        {
            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetChildrenActive()
    {
        foreach (GameObject go in GO)
        {
            go.SetActive(true);
            go.GetComponentInChildren<Button>().interactable = false;
            go.GetComponentInChildren<Image>().enabled = false;
        }
        DisableButton();
        DisableItem();
        
    }

    public void DisableItem()
    {
        
        Debug.Log(parent.name);
        
        parent.tag = "Untagged";
        DisableButton();
    }
    public void DisableButton()
    {
        button = GetComponentInChildren<Button>();
        Debug.Log(button + "button to disable");
                
        if (button.GetComponent<Image>() != null)
        {
            image = button.GetComponent<Image>();
            image.enabled = false;
        }
        
            
        button.enabled = false;
        button = null;
        image = null;
        
    }

    

}
