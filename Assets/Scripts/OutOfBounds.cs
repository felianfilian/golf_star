using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float resetTime = 2f; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            BallController.instance.outOfBounds = true;
            StartCoroutine(ResetBallCo());
        }
    }

    private IEnumerator ResetBallCo()
    {
        UIController.instance.ShowOutText();
        GameManager.instance.ShotDisabled();
        GameManager.instance.CountScore(1);
        yield return new WaitForSeconds(resetTime);
        BallController.instance.ResetBallPosition();
        GameManager.instance.ShotActive();
        UIController.instance.HideOutText();
    }
}
