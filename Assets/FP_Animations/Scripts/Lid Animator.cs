using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidAnimator : MonoBehaviour
{
    public Animator animator;
    
    
    CharacterMove characterMove; // skapar slot d�r CharacterMovescriptet kan l�ggas  
    RemoveLid removeLid; // skapar slot d�r RemoveLid-scriptet kan l�ggas  

    void Start()
    {
        
        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // s�tter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

        removeLid = GameObject.FindObjectOfType<RemoveLid>(); // s�tter variabeln removeLid till det som finns i sloten med samma namn, dvs scriptet RemoveLid  

    }




    
    void Update()
    {
        animator.SetBool("lidWalk", characterMove.isMoving);

        animator.SetBool("isCarryingLid", removeLid.grabbed);

       
    }

}



    





