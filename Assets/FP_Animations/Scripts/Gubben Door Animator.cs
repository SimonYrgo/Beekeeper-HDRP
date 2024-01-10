using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GubbenDoorAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject gubbenDoorAnimations;

    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  

    Smoker smoker; // skapar slot där Smokerscriptet kan läggas  

    DoorInteract doorInteract; // skapar slot där DoorInteract-scriptet kan läggas  


    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

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


        animator.SetBool("gubbenOpeningDoor", doorInteract.openingDoor); // kollar om Gubben rör på sig > kör isf GubbenLidCarryWalk animationen i Animatiorcontrollern

       

    }
}
