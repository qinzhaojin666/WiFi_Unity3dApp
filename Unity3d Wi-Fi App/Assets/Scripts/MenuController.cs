using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public ButtonColorController b1;
    public ButtonColorController b2;
    public ButtonColorController b3;
    public ButtonColorController b4;
    public ButtonColorController b5;
    public ButtonColorController b6;
    public ButtonColorController b7;


    // Update is called once per frame
    public void StartAlgorythm ()
    {
        b1.activity = false;
        b2.activity = false;
        b3.activity = false;
        b4.activity = false;
        b5.activity = false;
        b6.activity = false;
        b7.activity = false;
    }

    public void StopAlgorythm()
    {
        b1.activity = true;
        b2.activity = true;
        b3.activity = true;
        b4.activity = true;
        b5.activity = true;
        b6.activity = true;
        b7.activity = true;
    }
}
