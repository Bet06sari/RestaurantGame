using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset;
    Transform player;
    void Start()
    {
        player = FindObjectOfType<player>().transform;
        offset = player.position-transform.position;
    }
    
    void LateUpdate()
    {
        transform.position = player.position - offset;
    }
}
