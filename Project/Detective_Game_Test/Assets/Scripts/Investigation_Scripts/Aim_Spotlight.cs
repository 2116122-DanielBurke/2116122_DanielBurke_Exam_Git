using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_Spotlight : MonoBehaviour
{
    Camera camera;
    Vector3 mouseWorldPos;

   
   

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15));
        Debug.DrawLine(transform.position, mouseWorldPos, Color.red);
        camera = Camera.main;
        transform.LookAt(mouseWorldPos);
    }
}
