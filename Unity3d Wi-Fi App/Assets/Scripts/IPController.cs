using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[System.Serializable]

public class IPController : MonoBehaviour
{
    public bool[] state = new bool[9];

    public InputField addressIPObj;

    string ipAddress;

    public float delay = 1.0f;

    public bool startApp = false;

    private int key1 = 0, key2 = 0, key3 = 0, key4 = 0, key5 = 0, key6 = 0, key7 = 0, key8 = 0, key9 = 0;

    public string intArray;

    public bool sendRequestToIP = false;

    public Animator animator;

    public ButtonColorController button1;
    public ButtonColorController button2;
    public ButtonColorController button3;
    public ButtonColorController button4;
    public ButtonColorController button5;
    public ButtonColorController button6;
    public ButtonColorController button7;
    public ButtonColorController button8;
    public ButtonColorController button9;

    private void Start()
    {
        addressIPObj.text = "192.168.1.1";
    }
    void Update()
    {
        if (startApp)
        {
            if (delay >= 0f)
            {

                delay -= Time.deltaTime;

            }
            if (delay <= 0f)
            {

                StartCoroutine(GettingState());
                FirstChecking();
                SecondChecking();

                intArray = key1.ToString() + key2.ToString() + key3.ToString() + key4.ToString() + key5.ToString() + key6.ToString() + key7.ToString() + key8.ToString() + key9.ToString();
                Debug.Log("Конечный массив: " + intArray);
                StartCoroutine(SendingState());
                delay = 1.0f;


            }
        }

        if (sendRequestToIP)
        {
            StartCoroutine(SendingState());
            sendRequestToIP = false;
            Debug.Log("Отправил запрос");

        }
    }

    public void CheckIP()
    {

        ipAddress = addressIPObj.text;
        StartCoroutine(GettingState());
    }

    public void GetIP()
    {

        ipAddress = addressIPObj.text;
        //startApp = true;
    }

 
    IEnumerator GettingState()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://"+ ipAddress + "/state"))
        {
            
#pragma warning disable CS0618 
            yield return www.Send();
#pragma warning restore CS0618 

            if (www.isNetworkError || www.isHttpError)
            {
               
                    //animator.Play("FatalError");
                
            }
            else
            {

                Load(www.downloadHandler.text);

                //Debug.Log(state);
 
                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator SendingState()
    {
        
        using (UnityWebRequest www = UnityWebRequest.Get("http://" + ipAddress + "/set" + intArray))
        {

#pragma warning disable CS0618
            yield return www.Send();
#pragma warning restore CS0618 

            if (www.isNetworkError || www.isHttpError)
            {
               
                   // animator.Play("FatalError");
                    //startApp = false;
                

            }
            else
            {

                Load(www.downloadHandler.text);

                //Debug.Log(state);

                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator StartState()
    {

        using (UnityWebRequest www = UnityWebRequest.Get("http://" + ipAddress + "/start"))
        {

#pragma warning disable CS0618
            yield return www.Send();
#pragma warning restore CS0618 

            if (www.isNetworkError || www.isHttpError)
            {

               // animator.Play("FatalError");
                //startApp = false;


            }
            else
            {

                Load(www.downloadHandler.text);

                //Debug.Log(state);

                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator StopState()
    {

        using (UnityWebRequest www = UnityWebRequest.Get("http://" + ipAddress + "/stop"))
        {

#pragma warning disable CS0618
            yield return www.Send();
#pragma warning restore CS0618 

            if (www.isNetworkError || www.isHttpError)
            {

               // animator.Play("FatalError");
               // startApp = false;


            }
            else
            {

                Load(www.downloadHandler.text);

                //Debug.Log(state);

                byte[] results = www.downloadHandler.data;
            }
        }
    }

    IEnumerator RebootState()
    {

        using (UnityWebRequest www = UnityWebRequest.Get("http://" + ipAddress + "/set 000000000"))
        {

#pragma warning disable CS0618
            yield return www.Send();
#pragma warning restore CS0618 

            if (www.isNetworkError || www.isHttpError)
            {

                //animator.Play("FatalError");
                //startApp = false;


            }
            else
            {

                Load(www.downloadHandler.text);

                //Debug.Log(state);

                byte[] results = www.downloadHandler.data;
            }
        }
    }

    public void Load(string savedData)
    {
        JsonUtility.FromJsonOverwrite(savedData, this);
    }

    void FirstChecking()
    {
        // 1 element
        if (state[0] == true)
        {
            key1 = 1;

        }
        else
        {

            key1 = 0;
        }
        // 2 element
        if (state[1] == true)
        {
            key2 = 1;

        }
        else
        {

            key2 = 0;
        }
        // 3 element
        if (state[2] == true)
        {
            key3 = 1;

        }
        else
        {

            key3 = 0;
        }
        // 4 element
        if (state[3] == true)
        {
            key4 = 1;

        }
        else
        {

            key4 = 0;
        }
        // 5 element
        if (state[4] == true)
        {
            key5 = 1;

        }
        else
        {

            key5 = 0;
        }
        // 6 element
        if (state[5] == true)
        {
            key6 = 1;

        }
        else
        {

            key6 = 0;
        }
        // 7 element
        if (state[6] == true)
        {
            key7 = 1;

        }
        else
        {

            key7 = 0;
        }
        // 8 element
        if (state[7] == true)
        {
            key8 = 1;

        }
        else
        {

            key8 = 0;
        }
        // 9 element
        if (state[8] == true)
        {
            key9 = 1;

        }
        else
        {

            key9 = 0;
        }

    }

    void SecondChecking()
    {
        // 1 button
        if (key1 == 1)
        {
            button1.activity = true;

        }
        if (key1 == 0)
        {
            button1.activity = false;

        }
        // 2 button
        if (key2 == 1)
        {
            button2.activity = true;

        }
        if (key2 == 0)
        {
            button2.activity = false;

        }
        // 3 button
        if (key3 == 1)
        {
            button3.activity = true;

        }
        if (key3 == 0)
        {
            button3.activity = false;

        }
        // 4 button
        if (key4 == 1)
        {
            button4.activity = true;

        }
        if (key4 == 0)
        {
            button4.activity = false;

        }
        // 5 button
        if (key5 == 1)
        {
            button5.activity = true;

        }
        if (key5 == 0)
        {
            button5.activity = false;

        }
        // 6 button
        if (key6 == 1)
        {
            button6.activity = true;

        }
        if (key6 == 0)
        {
            button6.activity = false;

        }
        // 7 button
        if (key7 == 1)
        {
            button7.activity = true;

        }
        if (key7 == 0)
        {
            button7.activity = false;

        }
        // 8 button
        if (key8 == 1)
        {
            button8.activity = true;

        }
        if (key8 == 0)
        {
            button8.activity = false;

        }
        // 9 button
        if (key9 == 1)
        {
            button9.activity = true;

        }
        if (key9 == 0)
        {
            button9.activity = false;

        }
    }

    public void StartButton()
    {
        //StartCoroutine(StartState());
        //StartCoroutine(GettingState());
        startApp = true;
    }
    public void StopButton()
    {
        StartCoroutine(StopState());
    }
    public void RebootButton()
    {
        StartCoroutine(RebootState());
    }
}
