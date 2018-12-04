using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour {

    Animator animator;

    void Start()
    {

        animator = GetComponent<Animator>();

    }

    public void ToMainMenu()
    {
        animator.SetBool("ToMainMenu", true);
        animator.SetBool("ToSettings", false);
       

    }

    public void ToSettings()
    {
        animator.SetBool("ToSettings", true);

    }
}
