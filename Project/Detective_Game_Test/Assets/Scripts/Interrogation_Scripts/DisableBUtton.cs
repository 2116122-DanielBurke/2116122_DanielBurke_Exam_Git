using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableBUtton : MonoBehaviour
{
    [SerializeField] Button button;
    private void Start()
    {
        
    }
    public void DisableButton()
    {
        button.interactable = false;
        button.tag = "Untagged";
    }
}
