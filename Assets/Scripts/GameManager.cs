using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;

    private int shotCounter = 0;
    private float resultDelay = 2f;

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

    public void CountScore(int amount)
    {
        score += amount;
        UIController.instance.UpdateScoreCount(score);
    }


    public void BallInHole()
    {
        StartCoroutine(showResultCo());
    }

    private IEnumerator showResultCo()
    {
        UIController.instance.ShowWinText();
        ShotDisabled();
        yield return new WaitForSeconds(resultDelay);
        UIController.instance.ShowResultScreen(GameManager.instance.score);
    }

    public void ShotActive()
    {
        ShotController.instance.canShot = true;
        CameraControl.instance.ShowIndicator();
        UIController.instance.sliderPower.gameObject.SetActive(true);
    }

    public void ShotDisabled()
    {
        ShotController.instance.canShot = false;
        BallController.instance.rb.velocity = Vector3.zero;
        CameraControl.instance.HideIndicator();
        UIController.instance.sliderPower.gameObject.SetActive(false);
    }
}
