using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
  private const float Real_Seconds_per_ingame_Day = 60f;

  private Transform clockHourHandTransform;
  private Transform clockMinuteHandTransform;
  private float day;

  private void Awake()
  {
    clockMinuteHandTransform = transform.Find("MinuteHand");
    clockHourHandTransform = transform.Find("HourHand");
  }

  private void Update()
  {
    day += Time.deltaTime / Real_Seconds_per_ingame_Day;

    float dayNormalized = day % 1f;

    float rotaionDegreesPerDay = 360f;
    float hoursPerDay = 24f;
    clockHourHandTransform.eulerAngles = new Vector3(0,90,-dayNormalized * rotaionDegreesPerDay);
    clockMinuteHandTransform.eulerAngles = new Vector3(0,90,-dayNormalized * rotaionDegreesPerDay * hoursPerDay);
  }
}
