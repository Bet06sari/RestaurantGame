using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hawai : MonoBehaviour
{
    [HideInInspector] public string names = "h";
    
    public AudioSource HawaiiMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            HawaiiMusic.Play();
        }
            
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            HawaiiMusic.Stop();
    
        }
    }
}
