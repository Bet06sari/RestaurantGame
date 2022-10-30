using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfLevel : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform EndLine;
    public Image LevelFillingBar;
    
    private float maxDistance;
    
    
    void Start()
    {
        maxDistance = 200;
        LevelFillingBar.fillAmount = 0.2f;
    }

    void Update()
    {
        if (Player.position.z <= maxDistance && Player.position.z <= EndLine.position.z)
        {
            float distance = 1 - (getDistance() / maxDistance);
            LevelFillingBar.fillAmount = distance - 0.1f;
        }
    }

    float getDistance()
    {
        return EndLine.position.z - Player.position.z;
    }
}
