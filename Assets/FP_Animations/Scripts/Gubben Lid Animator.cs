using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GubbenLidAnimator : MonoBehaviour
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

        animator.SetBool("isCarryingLid", removeLid.grabbed);

        animator.SetBool("gubbenLidCarryWalk", characterMove.isMoving); // kollar om Gubben rör på sig > kör isf GubbenLidCarryWalk animationen i Animatiorcontrollern

        animator.SetBool("liddenDroppad", removeLid.lidDropped);




    }
}
        








