using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiFiChecker : MonoBehaviour
{

    Animator animator;

    // Use this for initialization
    void Start()

    {
        animator = GetComponent<Animator>();

    }
    public void WiFiCheckerFunction()
    {

        if (Application.internetReachability != NetworkReachability.NotReachable)
        {

            animator.SetBool("WiFi_Find", true);
            Debug.Log("Wi-Fi is available");

        }
        else
        {
            animator.SetBool("WiFi_NotFind", true);
            Debug.Log("Wi-Fi is not available");

        }

    }
    public void ReturnToMainScreen()
    {

        animator.SetBool("WiFi_NotFind", false);

    }
}

