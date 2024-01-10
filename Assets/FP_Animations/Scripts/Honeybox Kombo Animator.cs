using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyboxKomboAnimator : MonoBehaviour
{
    public Animator animator;

    public GameObject gubbeMesh;

    public GameObject honeyboxMesh;

    CharacterMove characterMove; // skapar slot där CharacterMovescriptet kan läggas  

    TakeHoneyBox takeHoneyBox;




    void Start()
    {

        characterMove = GameObject.FindObjectOfType<CharacterMove>(); // sätter variabeln characterMove till det som finns i sloten med samma namn, dvs scriptet CharacterMove

        takeHoneyBox = GameObject.FindObjectOfType<TakeHoneyBox>();

        gubbeMesh.GetComponentInChildren<Renderer>().enabled = false;

        honeyboxMesh.GetComponentInChildren<Renderer>().enabled = false;

    }





    void Update()
    {

        animator.SetBool("isCarryingSmoker", takeHoneyBox.grabbed);

        if (takeHoneyBox.grabbed)
        {
            gubbeMesh.GetComponentInChildren<Renderer>().enabled = true;

            honeyboxMesh.GetComponentInChildren<Renderer>().enabled = true;
        }


        animator.SetBool("komboHoneyboxCarryWalk", characterMove.isMoving); // kollar om Gubben rör på sig > kör isf GubbenLidCarryWalk animationen i Animatiorcontrollern



        


    }

}

