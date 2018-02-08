using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class key : MonoBehaviour
{


    //get piano audio sourse 
    AudioSource piano;

    //get key target 
    public GameObject keyNote;
    //get key note
    public AudioClip note;
    //get animation controller 
    Animator keydown;
    //get anim name;
    public AnimationClip anim; 
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
            keydown.Play(anim.name);
            keydown.speed = 2; 
            piano.clip = note;
            piano.Play();

        }
    }

    void OnTriggerEnter(Collider other)
    {
        keydown.Play(anim.name,-1,0);
        keydown.speed = 2;
        piano.clip = note;
        piano.Play();
    }
}
