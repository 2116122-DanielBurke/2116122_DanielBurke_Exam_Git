using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
public class SelectionManager : MonoBehaviour
{
    public Blacklight_Controller blCon;
    [SerializeField] string selectableTag = "Selectable";
    
    Camera camera;
    [SerializeField] Image evidenceImage;
    RaycastHit hit;
    Vector3 oldPos;
    Transform target;
    Transform selection;
    bool isFilled;
    
    

    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;



    [SerializeField] Text dialogueText;

    [SerializeField] Transform _selection;
    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = "";
        evidenceImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (blCon.GetComponent<Blacklight_Controller>().isActive == true)
        {
            dialogueText.text = "";
        }
        if (_selection != null || blCon.GetComponent<Blacklight_Controller>().isActive == true)
        {            
            selection.GetComponentInChildren<Button>().interactable = false;            
            selection.GetComponentInChildren<Button>().GetComponent<Image>().enabled = false;
            var selectionRenderer = _selection.GetComponent<Renderer>();
            Material[] materials = selectionRenderer.materials;            
            evidenceImage.enabled = false;
            for (int i = 0; i < materials.Length; ++i)
            {
                
                materials[i] = defaultMaterial;
            }
            
            selectionRenderer.materials = materials;
        }

            _selection = null;
        if(blCon.GetComponent<Blacklight_Controller>().isActive == false)
        {
            camera = Camera.main;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    if (selection.childCount>0)
                    {
                        selection.GetComponentInChildren<Button>().interactable = true;
                        selection.GetComponentInChildren<Button>().GetComponent<Image>().enabled = true;
                    }
                    
                    var selectionTextMeshProUGUI = selection.GetComponent<Renderer>();

                    if (selectionTextMeshProUGUI != null)
                    {
                        
                        Material[] materials = selectionTextMeshProUGUI.materials;
                        for (int i = 0; i < materials.Length; ++i)
                        {
                            materials[i] = highlightMaterial;
                        }
                        _selection = selection;
                        selectionTextMeshProUGUI.materials = materials;
                    }
                } 
            }
        }
       
        if (dialogueText.text == "")
        {
            dialogueText.enabled = false;
        }
        else
        {
            dialogueText.enabled = true;
        }

        
    }

    

}
