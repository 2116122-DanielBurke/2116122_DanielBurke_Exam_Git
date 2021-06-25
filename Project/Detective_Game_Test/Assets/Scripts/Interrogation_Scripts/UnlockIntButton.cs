using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockIntButton : MonoBehaviour
{
    public Unlock_Manager UM;
    public GameObject button01, button02, button03, button04, button05, button06, button07, button08, button09, button10, button11;
    // Start is called before the first frame update
    void Start()
    {
        if(button01 == null)
        {
            return;
        }
        if (button02== null)
        {
            return;
        }
        if (button03 == null)
        {
            return;
        }
        if (button04 == null)
        {
            return;
        }
        if (button05 == null)
        {
            return;
        }
        if (button06 == null)
        {
            return;
        }
        if (button07 == null)
        {
            return;
        }
        if (button08 == null)
        {
            return;
        }
        if (button09 == null)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UnlockButtons01()
    {
        if (UM.unlock01)
        {
            button01.SetActive(true);
        }
        if (UM.unlock02)
        {
            button02.SetActive(true);
        }
        if (UM.unlock03)
        {
            button03.SetActive(true);
        }
        if (UM.unlock04)
        {
            button04.SetActive(true);
        }
        if (UM.unlock05)
        {
            button05.SetActive(true);
        }
        if (UM.unlock06)
        {
            button07.SetActive(true);
        }
        if (UM.unlock06)
        {
            button06.SetActive(true);
        }
        if (UM.unlock07)
        {
            button07.SetActive(true);
        }
        if (UM.unlock08)
        {
            button08.SetActive(true);
        }
        if (UM.unlock09)
        {
            button09.SetActive(true);
        }
        if (UM.unlock10)
        {
            button10.SetActive(true);
        }
        if (UM.unlock11)
        {
            button11.SetActive(true);
        }

    }
    public void UnlockButtons02()
    {
        if (UM.unlock01)
        {
            button01.SetActive(true);
        }
        if (UM.unlock02)
        {
            button02.SetActive(true);
        }
        if (UM.unlock03)
        {
            button03.SetActive(true);
        }
        if (UM.unlock04)
        {
            button04.SetActive(true);
        }
        if (UM.unlock05)
        {
            button05.SetActive(true);
        }
        if (UM.unlock06)
        {
            button07.SetActive(true);
        }
        if (UM.unlock06)
        {
            button06.SetActive(true);
        }
        if (UM.unlock07)
        {
            button07.SetActive(true);
        }
        if (UM.unlock08)
        {
            button08.SetActive(true);
        }
        if (UM.unlock09)
        {
            button09.SetActive(true);
        }
        if (UM.unlock10)
        {
            button10.SetActive(true);
        }
        if (UM.unlock11)
        {
            button11.SetActive(true);
        }
    }
    public void UnlockButtons03()
    {
        if (UM.unlock01)
        {
            button01.SetActive(true);
        }
        if (UM.unlock02)
        {
            button02.SetActive(true);
        }
        if (UM.unlock03)
        {
            button03.SetActive(true);
        }
        if (UM.unlock04)
        {
            button04.SetActive(true);
        }
        if (UM.unlock05)
        {
            button05.SetActive(true);
        }
        if (UM.unlock06)
        {
            button07.SetActive(true);
        }
        if (UM.unlock06)
        {
            button06.SetActive(true);
        }
        if (UM.unlock07)
        {
            button07.SetActive(true);
        }
        if (UM.unlock08)
        {
            button08.SetActive(true);
        }
        if (UM.unlock09)
        {
            button09.SetActive(true);
        }
        if (UM.unlock10)
        {
            button10.SetActive(true);
        }
        if (UM.unlock11)
        {
            button11.SetActive(true);
        }
    }
}
