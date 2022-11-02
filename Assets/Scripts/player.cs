using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator animator { get {return GetComponent<Animator>(); } }
    public static player instance;
    [SerializeField] private GameObject goAhead ;
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
    

    public AudioSource highHeels, win;


    private void Awake()
    {
        instance = this;
    }

    void FixedUpdate()
    {
        if (!alive || !_tapToStart) return;

        if (!gameFinish)
        {
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            transform.position += goAhead.transform.forward* moveSpeed *Time.deltaTime;
        }
        else
        {
            transform.Translate(Vector3.forward * 0 * Time.deltaTime);
            animator.SetBool("victory",true);
            highHeels.Stop();
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
            highHeels.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Chinese chinese = other.GetComponent<Chinese>();
        Mexico mexico = other.GetComponent<Mexico>();
        Italy italy = other.GetComponent<Italy>();
        Hawai hawai = other.GetComponent<Hawai>();
        Abd abd = other.GetComponent<Abd>();
        Etiyopya etiyopya = other.GetComponent<Etiyopya>();
        if (chinese || mexico || italy || hawai || abd || etiyopya)
        {
            _currentName = null;
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Chinese chinese = other.GetComponent<Chinese>();
        Mexico mexico = other.GetComponent<Mexico>();
        Italy italy = other.GetComponent<Italy>();
        Hawai hawai = other.GetComponent<Hawai>();
        Abd abd = other.GetComponent<Abd>();
        Etiyopya etiyopya = other.GetComponent<Etiyopya>();
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
        
        if (hawai)
        {
            _currentName = hawai.names;
        }
        
        if (abd)
        {
            _currentName = abd.names;
        }
        
        if (etiyopya)
        {
            _currentName = etiyopya.names;
        }
        
        if (other.tag.Equals("finish"))
        {
            gameFinish = true;
            win.Play();
        }
        
        if (other.tag.Equals("fireworks"))
        {
            fireworks.SetActive(true);
        }
    }
    
}
