using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonActive : MonoBehaviour
{
    [SerializeField] BoxCollider bCol;
    [SerializeField] Button button;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Active()
    {
        StartCoroutine(SetButtonActiveEnum());

    }
    IEnumerator SetButtonActiveEnum()
    {
        button.interactable = true;
        button.GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(2f);
        bCol.enabled = false;
        
    }
}
