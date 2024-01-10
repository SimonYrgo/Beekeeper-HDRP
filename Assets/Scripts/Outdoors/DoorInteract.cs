using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

public class DoorInteract : MonoBehaviour
{

    public bool doorCanOpen = false;

    public bool openingDoor = false; // tíll Open Door animationen i Animationcontrollern

    public TMP_Text messageBoard;

    TakeHoneyBox takeHoneyBox;


    public AudioSource soundPlayer;

    SoundLibrary soundLibrary;



    
    private void Start()
    {
        takeHoneyBox = GameObject.FindObjectOfType<TakeHoneyBox>();

        soundLibrary = GameObject.FindAnyObjectByType<SoundLibrary>();

    }


    // Update is called once per frame
    void Update()
    {

        // gör en bool huruvida dörren går att öppna 

        if (Input.GetKeyDown(KeyCode.Q) && doorCanOpen)
        {

            { 

            openingDoor = true;

            Invoke("theOpener", 0.8f);

            /*

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 2f);
            //bool hit = Physics.SphereCast(transform.position, 1f, transform.forward, out hitInfo, 1f, layerMask);

            if (hit)
            {

                

                OpenDoor openDoor;

                hitInfo.transform.TryGetComponent<OpenDoor>(out openDoor);

                if (openDoor != null)
                {
                    
                    openDoor.OnInteraction(hitInfo);

                    messageBoard.text = "Get HoneyBox and bring inside shed";

                    

                    takeHoneyBox.canGetHoneyBox = true;


                    soundPlayer.PlayOneShot(soundLibrary.soundsLevel1[5]);

                }
                else
                {
                    Debug.Log("Doesnt have an an Open Door Component");
                }

            */


            }
        }
    }

    private void theOpener()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 4f); // Raycasten var 2f lång tror jag först, men det var lite kort
        //bool hit = Physics.SphereCast(transform.position, 1f, transform.forward, out hitInfo, 1f, layerMask);

        if (hit)
        {



            OpenDoor openDoor;

            hitInfo.transform.TryGetComponent<OpenDoor>(out openDoor);

            if (openDoor != null)
            {

                openDoor.OnInteraction(hitInfo);

                messageBoard.text = "Get HoneyBox and bring inside shed";



                takeHoneyBox.canGetHoneyBox = true;


                soundPlayer.PlayOneShot(soundLibrary.soundsLevel1[5]);

            }
            else
            {
                Debug.Log("Doesnt have an an Open Door Component");
            }




        }



    }



}