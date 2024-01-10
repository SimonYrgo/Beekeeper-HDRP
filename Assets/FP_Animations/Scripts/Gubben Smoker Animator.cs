using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GubbenSmokerAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject gubbenSmokerAnimations;

    CharacterMove characterMove; // skapar slot d�r CharacterMovescriptet kan l�ggas  
    
    Smoker smoker;




    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // s�tter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

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


        animator.SetBool("gubbenSmokerCarryWalk", characterMove.isMoving); // kollar om Gubben r�r p� sig > k�r isf GubbenLidCarryWalk animationen i Animatiorcontrollern


       
        animator.SetBool("smokernDroppad", smoker.smokerDropped);


    }

    
}
