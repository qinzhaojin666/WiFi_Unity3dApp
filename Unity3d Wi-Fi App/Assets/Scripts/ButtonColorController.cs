using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorController : MonoBehaviour {

    Image button;
    private Color color;
    public IPController ipController;
    public int index;
   

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

        ColorUtility.TryParseHtmlString("#09FF0064", out color);
        button.GetComponent<Image>().color = color;
       
}
    void DisableButton()
    {
        
        ColorUtility.TryParseHtmlString("#FF6C6C", out color);
        button.GetComponent<Image>().color = color;
        

    }
    public void ChooseActivity()
    {
        //int i = 0;

   
      
        ipController.sendRequestToIP = true;

        if (ipController.state[index] == true)
        {

            ipController.state[index] = false;
            ipController.red.Play();
            ipController.youWin--;
        }
        else
        {
            ipController.state[index] = true;
            ipController.green.Play();
            ipController.youWin++;
        }

      

}
}
