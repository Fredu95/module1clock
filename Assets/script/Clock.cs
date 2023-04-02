using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update (){
        DateTime time = DateTime.Now;
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, 30 * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, 6 * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, 6 * time.Second);
    }
    

    
}
