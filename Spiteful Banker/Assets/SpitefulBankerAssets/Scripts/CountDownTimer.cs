using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public float startTime = 0f;
    public TextMeshProUGUI timerText1;
    public UnityEvent Timeover;

    float timer1 = 0f;
    
    void Start()
    {
        StartCoroutine(Timer1());
    }

    private IEnumerator Timer1()
    {
        timer1 = startTime;

        do
        {
            timer1 -= Time.deltaTime;

            FormatText1();

            yield return null;
        }
        while (timer1 > 0);
        if (timer1 <= 0)
        {
            timedone();
        }
    }

    private void FormatText1()
    {
        int days = (int)(timer1 / 86400) % 365;
        int hours = (int)(timer1 / 3600) % 24;
        int minutes = (int)(timer1 / 60) % 60;
        int seconds = (int)(timer1 % 60);
        timerText1.text = "";
        if (days > 0) 
        { 
            timerText1.text += days + "d";
        }
        if (hours > 0)
        {
            timerText1.text += hours + "h";
        }
        if (minutes > 0)
        {
            timerText1.text += minutes + "m";
        }
        if (seconds > 0)
        {
            timerText1.text += seconds + "s";
        }
    }
    void timedone()
    {
        Debug.Log("hi I'm Active");
        Timeover.Invoke();
    }
}
