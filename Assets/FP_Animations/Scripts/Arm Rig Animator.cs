using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRigAnimator : MonoBehaviour
{
    public Animator animator;
    private bool isArmsCarryLidWalk = false; // bool f�r att styra ChangeAnim-funktionen nedan 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnim(); 
        }
    }

    public void ChangeAnim()
    {
        isArmsCarryLidWalk = !isArmsCarryLidWalk; // s�tt denna bool till sin motsats
        animator.SetBool("armsWalkCarryLid", isArmsCarryLidWalk); // S�tter boolen i animatorn till samma state - (true/false) som  isWalkCarryLid
                                                          // animator.SetBool tar in 2 parametrar: boolens namn och true/false state      

    }

}
