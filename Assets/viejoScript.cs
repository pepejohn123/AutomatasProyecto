using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class viejoScript : MonoBehaviour
{
    Animator animator;
    [SerializeField]
    private viejitaScript XBotObj;
    public int YState; //Estado del viejito
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Console.Write("Hola");
        YState=animator.GetInteger("State");
        int XState=XBotObj.XState;
        bool jump=Input.GetKey("u");
        bool crouch=Input.GetKey("i");
        switch (YState)
        {
            
            case 0:
                if(jump)
                {
                    animator.SetInteger("State", 1);
                     
                }
                else if(crouch){
                    animator.SetInteger("State", 2);
                     
                }
                break;
            case 1:
                if(!crouch&&jump){
                    animator.SetInteger("State", 1);
                }
                else if(!jump){
                    animator.SetInteger("State", 0);
                }
                break;
            case 2:
                if(!jump &&crouch){
                    animator.SetInteger("State", 2);
                }
                else if(!crouch){
                    animator.SetInteger("State", 0);
                }
                break;
            case 3:
                break;
        }
    }
}

