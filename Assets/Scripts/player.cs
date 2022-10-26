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
    private Rigidbody _rigidbody;

    [HideInInspector]public string _currentName;
    
    bool alive = true;
    public GameObject GameOver;
    public GameObject TapToPlayScreen;
    public GameObject NextLevelScreen;
    public GameObject fireworks;
    private bool _tapToStart;
    public bool gameFinish;


    private void Awake()
    {
        instance = this;
    }

    void FixedUpdate()
    {
        if (!alive || !_tapToStart) return;

        if (!gameFinish)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * 0 * Time.deltaTime);
            animator.SetTrigger("idle");
            NextLevelScreen.SetActive(true);
        }
        
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_tapToStart)
        {
            TapToPlayScreen.SetActive(false);
            _tapToStart = true;
            animator.SetTrigger("walk");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // github push denemesi
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
        
        if (other.tag.Equals("finish"))
        {
            gameFinish = true;
        }
        
        if (other.tag.Equals("fireworks"))
        {
            fireworks.SetActive(true);
        }
    }
    
}
