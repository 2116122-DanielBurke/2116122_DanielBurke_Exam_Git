using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

public class Blacklight_Controller : MonoBehaviour
{
    Vector3 mouseWorldPos;
    SetButtonActive setButAc;
    public GameObject evidence;
    //public GameObject collider_Container;
   [SerializeField] float lightInt;
    public SpriteMask spriteM;
    public bool isActive = false;
    Camera currCamera;
    public Light light;
    public GameObject sMan;
    public GameObject[] lights;
    public GameObject[] buttons;
    [SerializeField] Image magGlas;
    

    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Roomlights");
        buttons = GameObject.FindGameObjectsWithTag("EvidenceButton");
       // sprite.enabled = false;
        spriteM.enabled = false;
        light.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15));
        Debug.DrawLine(transform.position, mouseWorldPos, Color.red);
        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        //Debug.DrawRay(transform.position, forward, Color.red);
        if (Input.GetMouseButtonDown(1))
        {
            OnMouseClick();
        }
        if (isActive)
        {
           
                foreach (GameObject light in lights)
                {

                    RenderSettings.ambientIntensity = 0.1f;
                    light.GetComponent<Light>().intensity = 0f;
                }
                foreach (GameObject button in buttons)
                {

                    button.GetComponent<Button>().interactable = false;

                }
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 1000))
                {
                    //collider_Container.transform.position = hit.point;
                    if (hit.collider.gameObject.tag == "Evidence")
                    {
                        Debug.Log("Hit Evidence Col");
                        evidence = hit.collider.gameObject;
                        evidence.GetComponent<SetButtonActive>().Active();
                        StartCoroutine(MagGlass());


                    }
                    else
                    {

                    }
                    evidence = null;
                }
            }
            else if (!isActive)
            {
                foreach (GameObject light in lights)
                {
                    RenderSettings.ambientIntensity = 1.75f;
                    light.GetComponent<Light>().intensity = lightInt;
                    magGlas.enabled = false;
                }
                foreach (GameObject button in buttons)
                {
                    button.GetComponent<Button>().interactable = true;

                }
            }
        }
            
    
    public void OnMouseClick()
    {
        if (!isActive)
        {
            //sMan.SetActive(false);
            light.intensity = 50f;
            //sprite.enabled = true;
            spriteM.enabled = true; 
            isActive = true;
            //collider_Container.SetActive(true);
            
        }
        else if (isActive)
        {
            //sMan.SetActive(true);
            light.intensity = 0;
            //sprite.enabled = false;
            spriteM.enabled = false;
            //collider_Container.SetActive(false);
            isActive = false;
        }
    }   
    IEnumerator MagGlass()
    {
        magGlas.enabled = true;
        yield return new WaitForSeconds(2);
        magGlas.enabled = false;
    }

}
