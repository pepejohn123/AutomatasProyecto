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
    [SerializeField]
    private scoreManager score;

    public float graceTime = 0.2f;

 
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

        if ((YState == 0 && (XState == 1 || XState == 2)) || (YState == 1 && XState == 1) || (YState == 2 && XState == 2))
        {
            StartCoroutine(DelayedEvaluation(XBotObj, YBotObj));
        }
        else
        {
            EvaluateStates(XState, YState);
        }


         
    }

    void EvaluateStates(int XState, int YState)
    {
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
                score.score++;

                break;
            case (2,1): //Patada viejita, viejito salta
                animator.SetInteger("State", 1);
                score.score++;
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

    IEnumerator DelayedEvaluation(viejitaScript XBotObj, viejoScript YBotObj)
    {
        // Wait for the old man's reaction time
        yield return new WaitForSeconds(graceTime);

        // Evaluate the states after the delay
        EvaluateStates(XBotObj.XState, YBotObj.YState);
    }

}
