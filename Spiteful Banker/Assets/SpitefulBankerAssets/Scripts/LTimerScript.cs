using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


public class LTimerScript : MonoBehaviour
{
    //script took an hour, and the formating came from https://youtu.be/J03p5l2V64I
    public float time;

    public TextMeshProUGUI timeText;

    public UnityEvent timesUp;

    private void FixedUpdate()
    {
        time -= Time.deltaTime;

        FormatText();

        if(time < 0)
        {
            timesUp.Invoke();
            Debug.Log("times up");

        }

    }


    private void FormatText()
    {
        int minutes = (int)(time / 60) % 60;
        int seconds = (int)(time % 60);

        timeText.text = minutes + "m" + seconds + "s";




    }


}
