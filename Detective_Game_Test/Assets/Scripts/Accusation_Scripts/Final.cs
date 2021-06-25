using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
   public Dropdown name, dropdown01, dropdown02, dropdown03;
    public Text nameText, d1text, d2text, d3text;
    public Text date, signature, scoreText, ev1, ev2, ev3, susName;
    string hhMM;
    int scoreInt = 100;
    public Button accuse;

    [SerializeField] string nameString;
    [SerializeField] List<string>ev1String;
    [SerializeField] List<string> ev2String;
    [SerializeField] List<string> ev3String;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hhMM = System.DateTime.Now.ToString("HH:mm");
       
        if (nameText.text == "" && d1text.text == "")
        {
            accuse.interactable = false;
        }
        else
        {
            accuse.interactable = true;
        }
    }
    public void Accuse()
    {
        date.text = hhMM;
        if(nameText.text == nameString)
        {
            susName.text = "You chose" + nameString;
        }
        else
        {
            susName.text = "You chose" + nameText;
            scoreInt -= 25;            
        }
        if (ev1String.Contains(d1text.text))
        {
            ev1.text = "You chose" + d1text;
            scoreInt -= 25;
        }
        else
        {
            ev1.text = "You chose" + d1text;
        }
        if (ev2String.Contains(d2text.text))
        {
            ev2.text = "You chose" + d2text;
            
        }
        else
        {
            scoreInt -= 25;
            ev2.text = "You chose" + d2text.text;
        } if (ev3String.Contains(d3text.text))
        {

            ev3.text = "You chose" + d3text;
        }
        else
        {
            ev3.text = "You chose" + d3text.text;
            scoreInt -= 25;
        }
        scoreText.text = "" + scoreInt;
        signature.text = "The effective detective";
    }

}
