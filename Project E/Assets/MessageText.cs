using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageText : MonoBehaviour
{

    public GameObject Message;
    public Text TextofMessage;
    public bool Finished = false;

    // Start is called before the first frame update
    void Start()
    {
        Message.GetComponent<Image>().enabled = false;
        TextofMessage.text = "";
    }

    // Update is called once per frame
    public void Text(string text_message, int time_message)
    {
        Message.GetComponent<Image>().enabled = true;
        TextofMessage.text = text_message;
        
        StartCoroutine(WaitTime(time_message));
        
        
    }

//Delete the message after tot time
    void Update(){
        if(Finished==true){
            Message.GetComponent<Image>().enabled = false;
            TextofMessage.text = "";
            Finished=false;
        }
    }

//Wait tot time
    IEnumerator WaitTime(int time){
        yield return new WaitForSeconds(time);
        Finished=true;
    }
}
