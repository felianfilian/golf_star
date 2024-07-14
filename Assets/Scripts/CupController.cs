using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupController : MonoBehaviour
{
    public static CupController instance;
    public bool ballInCup;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ballInCup = true;
            ShotController.instance.canShot = false;
            BallController.instance.rb.velocity = Vector3.zero;
            UIController.instance.ShowWinScreen();
        }
    }
}
