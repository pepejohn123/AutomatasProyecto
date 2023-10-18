using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class viejitaScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public int XState;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        XState=animator.GetInteger("State");

        bool fight=Input.GetKey("f");
        bool kick=Input.GetKey("d");
        switch(XState)
        {
            case 0:
                if(fight){
                    
                    animator.SetInteger("State", 1);
                }
                else if(kick){
                    animator.SetInteger("State", 2);
                }
                break;
            case 1:
                if(!kick&&fight){
                    animator.SetInteger("State", 1);
                }
                else if(!fight){
                    animator.SetInteger("State", 0);
                }
                break;
            case 2:
                if(!fight &&kick){
                    animator.SetInteger("State", 2);
                }
                else if(!kick){
                    animator.SetInteger("State", 0);
                }
                break;

        }
    }
}
