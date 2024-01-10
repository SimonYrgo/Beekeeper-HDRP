using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GubbenSmokerAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject gubbenSmokerAnimations;

    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  
    
    Smoker smoker;




    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

        smoker = GameObject.FindObjectOfType<Smoker>();

        gubbenSmokerAnimations.GetComponentInChildren<Renderer>().enabled = false;

    }



    

    void Update()
    {

        animator.SetBool("isCarryingSmoker", smoker.grabbed);

        if (smoker.grabbed)
        {
            gubbenSmokerAnimations.GetComponentInChildren<Renderer>().enabled = true;
        }


        animator.SetBool("gubbenSmokerCarryWalk", characterMove.isMoving); // kollar om Gubben rör på sig > kör isf GubbenLidCarryWalk animationen i Animatiorcontrollern


       
        animator.SetBool("smokernDroppad", smoker.smokerDropped);


    }

    
}
