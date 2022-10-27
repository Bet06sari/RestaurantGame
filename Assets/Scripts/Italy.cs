using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Italy : MonoBehaviour
{
    [HideInInspector] public string names="i";
    
    public AudioSource ItalyMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            ItalyMusic.Play();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            ItalyMusic.Stop();

        }
    }
}
