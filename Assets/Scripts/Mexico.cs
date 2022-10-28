using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mexico : MonoBehaviour
{
    [HideInInspector] public string names="m";
    //[SerializeField] private Animator anim;
    
    public AudioSource MexicoMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            MexicoMusic.Play();
            //anim.SetTrigger("mexicoTrigger");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            MexicoMusic.Stop();

        }
    }
}
