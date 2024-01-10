using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokerAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject smokerAnimations;
    

    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  
    
    Smoker smoker;



    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

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
