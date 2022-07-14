using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Next_Advisor : MonoBehaviour
{

    public MessageText script;

    void Update()
    {
        bool Next = Input.GetButtonDown("Submit");
        if(Next==true){
            script.Text("prossimo consigliere, per favore", 2);
        }
    }
}
