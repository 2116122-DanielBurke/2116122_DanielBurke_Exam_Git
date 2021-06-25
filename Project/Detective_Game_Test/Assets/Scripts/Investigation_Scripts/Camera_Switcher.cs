using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switcher : MonoBehaviour
{
   public Camera cam1, cam2, cam3, cam4, cam5;
   public GameObject blacklight;
   public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        if (cam1 == null) return;
        if (cam2 == null) return;
        if (cam3 == null) return;
        if (cam4 == null) return;
        if (cam5 == null) return;
        
        light.transform.position = cam1.transform.position;
        light.transform.rotation = cam1.transform.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && cam1 != null)
            SwitchCamera1();
        if (Input.GetKeyDown(KeyCode.Alpha2) && cam2 != null)
            SwitchCamera2();        
        if (Input.GetKeyDown(KeyCode.Alpha3) && cam3 != null)
            SwitchCamera3();
        if (Input.GetKeyDown(KeyCode.Alpha4) && cam4 != null)
            SwitchCamera4();
    }

    public void SwitchCamera1()
    {
        cam1.tag = "MainCamera";
        cam2.tag = "Untagged";
        cam3.tag = "Untagged";
        cam4.tag = "Untagged";
        cam5.tag = "Untagged";

        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        light.transform.position = cam1.transform.position;
        light.transform.rotation = cam1.transform.rotation;
        
    }
    public void SwitchCamera2()
    {
        cam1.tag = "Untagged";
        cam2.tag = "MainCamera";
        cam3.tag = "Untagged";
        cam4.tag = "Untagged";
        cam5.tag = "Untagged";
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;

        light.transform.position = cam2.transform.position;
        light.transform.rotation = cam2.transform.rotation;
        
    }
    public void SwitchCamera3()
    {
        cam1.tag = "Untagged";
        cam2.tag = "Untagged";
        cam3.tag = "MainCamera";
        cam4.tag = "Untagged";
        cam5.tag = "Untagged";
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = true;
        cam4.enabled = false;
        cam5.enabled = false;
        light.transform.position = cam3.transform.position;
        light.transform.rotation = cam3.transform.rotation;
       
    }
    public void SwitchCamera4()
    {
        cam1.tag = "Untagged";
        cam2.tag = "Untagged";
        cam3.tag = "Untagged";
        cam4.tag = "MainCamera";
        cam5.tag = "Untagged";
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = true;
        cam5.enabled = false;
        light.transform.position = cam4.transform.position;
        light.transform.rotation = cam4.transform.rotation;
        
    }
    public void SwitchCamera5()
    {
        cam1.tag = "Untagged";
        cam2.tag = "Untagged";
        cam3.tag = "Untagged";
        cam4.tag = "Untagged";
        cam5.tag = "MainCamera";

        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = true;
    }
}
