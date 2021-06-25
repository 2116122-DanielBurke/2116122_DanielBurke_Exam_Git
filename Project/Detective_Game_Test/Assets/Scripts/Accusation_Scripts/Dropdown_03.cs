using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown_03 : MonoBehaviour
{
    public Text textbox;
    public Dropdown dropdown;
    public List<string> items;
    [SerializeField] string s1, s2, s3, s4, s5;
    // Start is called before the first frame update
    void Start()
    {

        dropdown.options.Clear();
        items = new List<string>();
        items.Add("No evidence");
        items.Add(s1);
        items.Add(s2);
        items.Add(s3);
        items.Add(s4);
        items.Add(s5);

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

        DropDownItemSelected(dropdown);
        dropdown.onValueChanged.AddListener(delegate { DropDownItemSelected(dropdown); });

    }

    // Update is called once per frame



    void DropDownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        textbox.text = dropdown.options[index].text;
    }
}