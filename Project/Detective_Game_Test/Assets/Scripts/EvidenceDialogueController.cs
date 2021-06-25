using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceDialogueController : MonoBehaviour
{
    public GameObject evidenceGO;
    public GameObject dialogueGO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EvidenceOnClick()
    {
        if (evidenceGO.activeInHierarchy)
        {
            evidenceGO.SetActive(false);
        }
        else
        {
            evidenceGO.SetActive(true);
        }
    }
    public void DialogueOnClick()
    {
        if (dialogueGO.activeInHierarchy)
        {
            dialogueGO.SetActive(false);
        }
        else{
            dialogueGO.SetActive(true);
        }
    }
}
