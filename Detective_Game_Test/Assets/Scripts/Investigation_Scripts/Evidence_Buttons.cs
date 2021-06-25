using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Evidence_Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HelloWorld()
    {
        Debug.Log(gameObject.GetComponentInChildren<Button>().name);
    }
}
