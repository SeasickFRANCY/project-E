using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changeDate : MonoBehaviour
{
    public Text Clock;
    public Text Speed;
    public System.TimeSpan timeSpan = new System.TimeSpan(0, 0, 0, 0, 0);
    public System.DateTime date = new System.DateTime(1864, 03, 10);
    public System.DateTime dateTime;
    public float timeRate = 1;

    public void Update()
    {
        //Stop and Start
        bool StopStart = Input.GetButtonDown("Jump");
        if(StopStart==true){
            if(timeRate==0){
                timeRate=100000;
                Speed.text = "1x";
            }else{
                timeRate=0;
                Speed.text = "STOP";
            }
        }



        float milliseconds = Time.deltaTime * 1000 * timeRate;

        timeSpan += new System.TimeSpan(0, 0, 0, 0, (int)milliseconds);
        dateTime = date.Add(timeSpan);

        Clock.text = dateTime.ToString("dd MMMM yyyy");

    }

}
