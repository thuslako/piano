using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{


    //get piano audio sourse 
    AudioSource piano;

    //get key target 
    public GameObject keyNote;



    //get key note; 

    public AudioClip note;



    //get animation controller 

    Animator keydown;



    //note to display 



    // Use this for initialization
    void Start()
    {

        piano = FindObjectOfType<AudioSource>();

        keydown = keyNote.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("c"))
        {

            keydown.speed = 2;
            keydown.StartPlayback(); 
            piano.clip = note;

            piano.Play();

        }
    }



    //check collision

    void OnCollisionEnter(Collision col)

    {

        //check if piano key is pressed 

        if (col.gameObject == keyNote)
        {

            keydown.speed = 2;

            piano.clip = note;

            piano.Play();

            Debug.Log("play note");

        }

    }
}
