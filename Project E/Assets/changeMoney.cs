using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changeMoney : MonoBehaviour
{

    public Text money;
    public int Moneys;

    public changeDate script;
    private System.DateTime Date;
    bool Stop=false;
    public int Gainings;

    // Start is called before the first frame update
    void Start()
    {
        money.text = "100";
        Moneys = int.Parse(money.text);
        money.text = Moneys.ToString();
    }

    public void Update(){
        
        Date = script.dateTime;
        if((Date.ToString("dd")=="01") && Stop == false){
            Moneys += Gainings;
            money.text = Moneys.ToString();
            Stop = true;
        }else if(Date.ToString("dd")=="02"){Stop = false;}

    }
}
