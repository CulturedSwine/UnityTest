using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour {

    public bool firstTrigger;
    public bool secondTrigger;

    void Start() {
        var testTrigger1 = GameObject.Find("plate1");
        firstTrigger = testTrigger1.GetComponent<TriggerScript>();
        Debug.Log(firstTrigger);
    }
    void Update() {
        if (firstTrigger == true && secondTrigger == true){
            GetComponent<SpriteRenderer>().material.color = new Color(0,1,0);   
        }
    }

}