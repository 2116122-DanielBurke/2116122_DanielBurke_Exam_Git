using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Dialogue : MonoBehaviour
{
    Button button;

    string hhMM;
    
    GameObject chat, response;
    
    [SerializeField] Transform dialogBox, responseBox;
    [SerializeField] GameObject textPrefab, responsePrefab;
    [SerializeField] string option1, option2, option3, option4, option5, option6, option7, option8, option9, option10, option11;
    [SerializeField] string response1, response2, response3, response4, response5, response6, response7, response8, response9, response10, response11;
    GameObject[] dialogButton;
    [SerializeField] GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.FindGameObjectsWithTag("DialogueButton");
    }

    // Update is called once per frame
    void Update()
    {
        hhMM = System.DateTime.Now.ToString("hh:mm");
        dialogButton = GameObject.FindGameObjectsWithTag("DialogueButton");

    }

    public void Option1()
    {
        StartCoroutine(Response01());
        buttons[0].GetComponent<Button>().interactable = false;
        buttons[0].GetComponent<Button>().tag = "Untagged";
    }    
    IEnumerator Response01()
    {
        foreach(GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option1;
        
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response1;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option2()
    {
        StartCoroutine(Response02());
        buttons[1].GetComponent<Button>().interactable = false;
        buttons[1].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response02()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option2;
        
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response2;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option3()
    {
        StartCoroutine(Response03());
        buttons[2].GetComponent<Button>().interactable = false;
        buttons[2].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response03()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option3;
        
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response3;
        
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option4()
    {
        StartCoroutine(Response04());
        buttons[3].GetComponent<Button>().interactable = false;
        buttons[3].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response04()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option3;
      
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response3;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option5()
    {
        StartCoroutine(Response05());
        buttons[4].GetComponent<Button>().interactable = false;
        buttons[4].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response05()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option5;
       
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response5;
        
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option6()
    {
        StartCoroutine(Response06());
        buttons[5].GetComponent<Button>().interactable = false;
        buttons[5].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response06()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option6;
        
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response6;
        
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option7()
    {
        StartCoroutine(Response07());
        buttons[6].GetComponent<Button>().interactable = false;
        buttons[6].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response07()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option7;
       
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response7;
        
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option8()
    {
        StartCoroutine(Response08());
        buttons[7].GetComponent<Button>().interactable = false;
        buttons[7].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response08()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option8;
        
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response8;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option9()
    {
        StartCoroutine(Response09());
        buttons[8].GetComponent<Button>().interactable = false;
        buttons[8].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response09()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option9;
       
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response9;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option10()
    {
        StartCoroutine(Response10());
        buttons[9].GetComponent<Button>().interactable = false;
        buttons[9].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response10()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option10;
       
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response10;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
    public void Option11()
    {
        StartCoroutine(Response11());
        buttons[10].GetComponent<Button>().interactable = false;
        buttons[10].GetComponent<Button>().tag = "Untagged";
    }
    IEnumerator Response11()
    {
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = false;
        }
        chat = Instantiate(textPrefab, dialogBox);
        chat.GetComponentInChildren<Text>().text = option11;
       
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        response = Instantiate(responsePrefab, responseBox);
        response.GetComponentInChildren<Text>().text = response11;
       
        foreach (GameObject button in dialogButton)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
   }


