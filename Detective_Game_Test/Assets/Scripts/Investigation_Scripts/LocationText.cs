using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LocationText : MonoBehaviour
{
    [SerializeField] string loc1, loc2, loc3, loc4;
    [SerializeField] Camera cam1, cam2, cam3, cam4;
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main == cam1)
        {
            text.text = loc1;
        }else if(Camera.main == cam2)
        {
            text.text = loc2;
        }
        else if (Camera.main == cam3)
        {
            text.text = loc3;
        }
        else if (Camera.main == cam4)
        {
            text.text = loc4;
        }
    }
}
