using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abd : MonoBehaviour
{
    [HideInInspector] public string names = "a";
    
    public AudioSource abdMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            abdMusic.Play();
        }
            
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            abdMusic.Stop();
    
        }
    }
}
