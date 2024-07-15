using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int shotCounter = 0;
    private int score = 0;
    

    private void Awake()
    {
        instance = this;
    }

    public void CountShot()
    {
        shotCounter++;
        if (score < 5)
        {
            score++;
        }
        else if (score == 6) 
        {
            score = 7;
        }
        UIController.instance.UpdateScoreCount(score);
        UIController.instance.UpdateShotCount(shotCounter);
    }

    public void BallInHole()
    {
        ShotController.instance.canShot = false;
        BallController.instance.rb.velocity = Vector3.zero;
        UIController.instance.ShowWinText();
        UIController.instance.ShowResultScreen(score);
    }
}
