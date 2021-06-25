using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
   public Dropdown name, dropdown01, dropdown02, dropdown03;
    public Text nameText, d1text, d2text, d3text;
    public Text date, signature, scoreText, ev1, ev2, ev3, susName;
    public Image baseImage;
    public Sprite image01, image02, image03;
    string hhMM;
    int scoreInt = 100;
    public Button accuse;

    [SerializeField] string nameString, option1, option2, option3;
    [SerializeField] List<string>ev1String;
    [SerializeField] List<string> ev2String;
    [SerializeField] List<string> ev3String;
    // Start is called before the first frame update
    void Start()
    {
        signature.text = "The Effective Detective";
    }

    // Update is called once per frame
    void Update()
    {
        hhMM = System.DateTime.Now.ToString("dd/MM/yyyy");

        date.text = hhMM;

        if (nameText.text == option1)
        {
            baseImage.enabled = true;
            baseImage.sprite = image01;
        }else if (nameText.text == option2)
        {
            baseImage.enabled = true;
            baseImage.sprite = image02;
        }
        else if (nameText.text == option3)
        {
            baseImage.enabled = true;
            baseImage.sprite = image03;
        }else if(nameText.text == "No available suspect")
        {
            baseImage.enabled = false;
        }
    }
    public void Accuse()
    {
      
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
        
    }

}
