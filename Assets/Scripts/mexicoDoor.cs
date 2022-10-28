using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mexicoDoor : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource _mexicoDoor;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _mexicoDoor.Play();
            anim.SetTrigger("mexicoTrigger");
        }
    }
}
