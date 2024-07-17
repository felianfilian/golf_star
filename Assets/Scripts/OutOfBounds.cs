using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            BallController.instance.outOfBounds = true;
            UIController.instance.ShowOutText();
            GameManager.instance.ShotDisabled();
            GameManager.instance.CountScore(1);
        }
    }
}
