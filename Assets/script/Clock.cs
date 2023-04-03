using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update (){
        TimeSpan time = DateTime.Now.TimeOfDay;
       // Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
        
        DateTime Time = DateTime.Now;
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Seconds);
    }
    


    
}
