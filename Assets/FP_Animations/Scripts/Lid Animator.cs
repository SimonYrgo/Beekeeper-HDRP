using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidAnimator : MonoBehaviour
{
    public Animator animator;
    
    
    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  
    RemoveLid removeLid; // skapar slot där RemoveLid-scriptet kan läggas  

    void Start()
    {
        
        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

        removeLid = GameObject.FindObjectOfType<RemoveLid>(); // sätter variabeln removeLid till det som finns i sloten med samma namn, dvs scriptet RemoveLid  

    }




    
    void Update()
    {
        animator.SetBool("lidWalk", characterMove.isMoving);

        animator.SetBool("isCarryingLid", removeLid.grabbed);

       
    }

}



    





