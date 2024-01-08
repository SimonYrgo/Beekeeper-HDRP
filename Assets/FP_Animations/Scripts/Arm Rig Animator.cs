using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRigAnimator : MonoBehaviour
{
    public Animator animator;
    private bool isArmsCarryLidWalk = false; // bool för att styra ChangeAnim-funktionen nedan 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnim(); 
        }
    }

    public void ChangeAnim()
    {
        isArmsCarryLidWalk = !isArmsCarryLidWalk; // sätt denna bool till sin motsats
        animator.SetBool("armsWalkCarryLid", isArmsCarryLidWalk); // Sätter boolen i animatorn till samma state - (true/false) som  isWalkCarryLid
                                                          // animator.SetBool tar in 2 parametrar: boolens namn och true/false state      

    }

}
