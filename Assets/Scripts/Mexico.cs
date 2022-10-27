using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mexico : MonoBehaviour
{
    [HideInInspector] public string names="m";
    
    public AudioSource MexicoMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            MexicoMusic.Play();

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
