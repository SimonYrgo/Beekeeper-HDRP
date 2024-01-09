using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ArmRigAnimator : MonoBehaviour
{
    public Animator animator;
    //private bool isGubbenLidCarryWalking = false; // bool för att styra ChangeAnim-funktionen nedan 
    
    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  


    void Start()
    {
    
    characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

    animator.SetBool("gubbenLidCarryWalk", characterMove.isMoving);
    
    }


    /*
    void Update()
    {
        animator.SetBool("gubbenLidCarryWalk", isGubbenLidCarryWalking);
    }

    */

    /*
     * CARLS KOD nedan för att byta mellan states i Animator Controllern >>>

    
    

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
        animator.SetBool("gubbenLidCarryWalk", isArmsCarryLidWalk); // Sätter boolen i animatorn till samma state - (true/false) som  isWalkCarryLid
                                                          // animator.SetBool tar in 2 parametrar: boolens namn och true/false state      

    }

    */

}
