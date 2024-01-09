using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ArmRigAnimator : MonoBehaviour
{
    public Animator animator;
    //private bool isGubbenLidCarryWalking = false; // bool f�r att styra ChangeAnim-funktionen nedan 
    
    CharacterMove characterMove; // skapar slot d�r CharacterMovescriptet kan l�ggas  


    void Start()
    {
    
    characterMove = GameObject.FindObjectOfType<CharacterMove>(); // s�tter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

    animator.SetBool("gubbenLidCarryWalk", characterMove.isMoving);
    
    }


    /*
    void Update()
    {
        animator.SetBool("gubbenLidCarryWalk", isGubbenLidCarryWalking);
    }

    */

    /*
     * CARLS KOD nedan f�r att byta mellan states i Animator Controllern >>>

    
    

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
        animator.SetBool("gubbenLidCarryWalk", isArmsCarryLidWalk); // S�tter boolen i animatorn till samma state - (true/false) som  isWalkCarryLid
                                                          // animator.SetBool tar in 2 parametrar: boolens namn och true/false state      

    }

    */

}
