using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator animator { get {return GetComponent<Animator>(); } }
    public static player instance;
    [SerializeField] private GameObject chineseButton, mexicoButton, italyButton;
    public float moveSpeed = 1.5f;
    public Transform rayOrigin;
    private Rigidbody _rigidbody;

    [HideInInspector]public string _currentName;


    private void Awake()
    {
        instance = this;
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerExit(Collider other)
    {
        Chinese chinese = other.GetComponent<Chinese>();
        Mexico mexico = other.GetComponent<Mexico>();
        Italy italy = other.GetComponent<Italy>();
        if (chinese || mexico || italy)
        {
            _currentName = null;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Chinese chinese = other.GetComponent<Chinese>();
        Mexico mexico = other.GetComponent<Mexico>();
        Italy italy = other.GetComponent<Italy>();
        if (chinese)
        {
            _currentName = chinese.names;
        }
        

        if (mexico)
        {
            _currentName = mexico.names;
            
        }

        if (italy)
        {
            _currentName = italy.names;
        }
    }
    
}
