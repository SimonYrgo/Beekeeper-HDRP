using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidAnimator : MonoBehaviour
{
    public Animator animator;
    private bool isLidWalk = false; // bool för att styra ChangeAnim-funktionen nedan 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnim();
        }
    }

    public void ChangeAnim()
    {
        isLidWalk = !isLidWalk; // sätt denna bool till sin motsats
        animator.SetBool("lidWalk", isLidWalk); // Sätter boolen i animatorn till samma state - (true/false) som  isWalkCarryLid
                                                                  // animator.SetBool tar in 2 parametrar: boolens namn och true/false state      

    }
}




