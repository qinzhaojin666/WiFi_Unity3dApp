using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorController : MonoBehaviour {

    Image button;

    public bool activity = true;

    void Start()
    {

       button = GetComponent<Image>();

    }

    void Update()
    {


        if (activity)
        {
            ActiveButton();
        }
        else
        {
            DisableButton();
        }


    }

    void ActiveButton()
    {

        button.color = Color.white;

    }
    void DisableButton()
    {

        button.color = Color.red;

    }
    public void ChooseActivity()
    {

        if (activity)
        {
            activity = false;
        }
        else
        {
            activity = true;
        }


    }
}
