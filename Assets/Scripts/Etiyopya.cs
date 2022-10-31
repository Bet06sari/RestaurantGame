using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etiyopya : MonoBehaviour
{
    [HideInInspector] public string names = "e";
    
    public AudioSource etiyopyaMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            etiyopyaMusic.Play();
        }
            
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            etiyopyaMusic.Stop();
    
        }
    }
}
