using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidAnimator : MonoBehaviour
{
    public Animator animator;
    // private bool isLidCarryWalking = false; // bool för att styra ChangeAnim-funktionen nedan 
    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  

    void Start()
    {
        
        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove
        
        animator.SetBool("gubbenLidCarryWalk", characterMove.isMoving);

    }
        

        

    /*
    void Update()
    {
        animator.SetBool("gubbenLidCarryWalk", isLidCarryWalking);
        
    }

    */

    /* CARLS KOD nedan >>>



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnim();
        }
    }

    public void ChangeAnim()
    {
        isLidCarryWalking = !isLidCarryWalking; // sätt denna bool till sin motsats
        animator.SetBool("lidWalk", isLidCarryWalking); // Sätter boolen i animatorn till samma state - (true/false) som  isWalkCarryLid
                                                                  // animator.SetBool tar in 2 parametrar: boolens namn och true/false state      

    }

    */
}




