using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chineseDoor : MonoBehaviour
{
    [SerializeField] private AudioSource _chineseDoor;
    [SerializeField] private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _chineseDoor.Play();
            anim.SetTrigger("chineseTrigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _chineseDoor.Stop();
        }
    }
}
