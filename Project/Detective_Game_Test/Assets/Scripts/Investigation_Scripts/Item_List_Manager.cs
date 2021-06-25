using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_List_Manager : MonoBehaviour
{
   
    public List<string> ItemButtonList = new List<string> { "x", "y" };
    // Start is called before the first frame update
    void Start()
    {
        ItemButtonList = this.ItemButtonList; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
