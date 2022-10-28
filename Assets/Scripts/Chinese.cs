using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chinese : MonoBehaviour
{
    [HideInInspector] public string names = "c";

    public AudioSource ChineseMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            ChineseMusic.Play();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            ChineseMusic.Stop();

        }
    }
}