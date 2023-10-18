using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninoScript : MonoBehaviour
{
    
    Animator animator;
    
    [SerializeField]
    Animator animator2;
    [SerializeField]
    Animator animator3;
    [SerializeField]
    private viejitaScript XBotObj;
    [SerializeField]
    private viejoScript YBotObj;
 
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
     
    }

    // Update is called once per frame
    void Update()
    {
        int XState=XBotObj.XState; //VIEJITA
        int YState=YBotObj.YState; //VIEJO
        switch (XState,YState)
        {
            case (0,0): //No hacen nada
                animator.SetInteger("State", 0);
                break;
            case (1,0): //Puño viejita, viejito idle
                animator.SetInteger("State", 2);
                animator2.SetInteger("State", 3);
                animator3.SetInteger("State", 3);
                break;
            case (2,0): //Patada viejita, viejito idle
                animator.SetInteger("State", 2);
                animator2.SetInteger("State", 3);
                animator3.SetInteger("State", 3);

                break;
            case (1,1): //Puño viejita, viejito salta
                animator.SetInteger("State", 2);
                animator2.SetInteger("State", 3);
                animator3.SetInteger("State", 3);
                break;
            case (1,2): //Puño viejita, viejito se agacha
                animator.SetInteger("State", 1);
                break;
            case (2,1): //Patada viejita, viejito salta
                animator.SetInteger("State", 1);
                break;        
            case (2,2)://Patada viejita, viejito se agacha
                animator.SetInteger("State", 2);
                animator2.SetInteger("State", 3);
                animator3.SetInteger("State", 3);
                break;
            default:
                animator.SetInteger("State",0);
                break;

        } 
    }
}
