using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DispalyToDialogue : MonoBehaviour
{
    [SerializeField] string text;
    public Text dialogueBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TypeToDialog()
    {
        StartCoroutine(Dialog());
    }

    IEnumerator Dialog()
    {
        dialogueBox.text = text;
        yield return new WaitForSeconds(2f);
        dialogueBox.text = "";
    }
}
