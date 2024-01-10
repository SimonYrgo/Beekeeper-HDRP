using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokerAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject smokerAnimations;
    

    CharacterMove characterMove; // skapar slot d�r CharacterMovescriptet kan l�ggas  
    
    Smoker smoker;



    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // s�tter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

        smoker = GameObject.FindObjectOfType<Smoker>();

        smokerAnimations.GetComponentInChildren<Renderer>().enabled = false;

    }





    void Update()
    {
        animator.SetBool("smokerWalk", characterMove.isMoving);

        // animator.SetBool("isCarryingSmoker", smoker.grabbed);

        if (smoker.grabbed)
        {
            smokerAnimations.GetComponentInChildren<Renderer>().enabled = true;
        }

        if (smoker.smokerDropped)
        {
            smokerAnimations.GetComponentInChildren<Renderer>().enabled = false;
        }


    }
}
