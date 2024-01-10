using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GubbenDoorAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject gubbenDoorAnimations;

    CharacterMove characterMove; // skapar slot d�r CharacterMovescriptet kan l�ggas  

    Smoker smoker; // skapar slot d�r Smokerscriptet kan l�ggas  

    DoorInteract doorInteract; // skapar slot d�r DoorInteract-scriptet kan l�ggas  


    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // s�tter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

        smoker = GameObject.FindObjectOfType<Smoker>();

        doorInteract = GameObject.FindObjectOfType<DoorInteract>();

        gubbenDoorAnimations.GetComponentInChildren<Renderer>().enabled = false;

    }





    void Update()
    {

        

        if (smoker.smokerDropped)
        {
            gubbenDoorAnimations.GetComponentInChildren<Renderer>().enabled = true;
        }


        animator.SetBool("gubbenOpeningDoor", doorInteract.openingDoor); // kollar om Gubben r�r p� sig > k�r isf GubbenLidCarryWalk animationen i Animatiorcontrollern

       

    }
}
