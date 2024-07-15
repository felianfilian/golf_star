using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CupController : MonoBehaviour
{
    public static CupController instance;
    public bool ballInCup = false;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ballInCup = true;
            GameManager.instance.BallInHole();
        }
    }

    
}
