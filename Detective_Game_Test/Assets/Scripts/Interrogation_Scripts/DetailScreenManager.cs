using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailScreenManager : MonoBehaviour
{
    [SerializeField] GameObject detailField, detailField02, detailField03;

    public void OnButtonPress()
    {
        if (detailField.activeInHierarchy)
        {
            detailField.SetActive(false);
        }
        else
        {
            detailField.SetActive(true);
            detailField02.SetActive(false);
            detailField03.SetActive(false);
        }
    }
}
