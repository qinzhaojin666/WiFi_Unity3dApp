using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiFiIsFind : MonoBehaviour {

    Animator animator;
	
	// Update is called once per frame
	void Start () {

        animator = GetComponent<Animator>();
		
	}

    public void WriteIPAdress()
    {

        animator.SetBool("IP", true);

    }
}
