using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateTime : MonoBehaviour
{
    [SerializeField] Text date, time;
    string hhMM;
    int hour, minute, day, month, year;

    private void Update()
    {
        hour = System.DateTime.Now.Hour;
        hhMM = System.DateTime.Now.ToString("HH:mm");
        time.text = hhMM;

        day = System.DateTime.Now.Day;
        month = System.DateTime.Now.Month;
        year = System.DateTime.Now.Year;
        date.text = "" + year + "/" + month + "/" + day;
    }
}
