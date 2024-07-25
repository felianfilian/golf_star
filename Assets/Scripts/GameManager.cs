using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string[] levelScenes;

    public int score = 0;
    public int fullScore;

    [Header("Scenes")]
    public string mainMenuScene = "Main_Menu";
    public string nextLevelScene = "Main_Menu";


    private int shotCounter = 0;
    private float resultDelay = 2f;

    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        if(PlayerPrefs.HasKey("full_score"))
        {
            fullScore = PlayerPrefs.GetInt("full_score");
            Debug.Log(fullScore);
        } else
        {
            fullScore = 0;
        }
        
    }

    public void CountShot()
    {
        shotCounter++;
        CountScore(1);
        UIController.instance.UpdateScoreCount(score);
        UIController.instance.UpdateShotCount(shotCounter);
    }

    public void CountScore(int amount)
    {
        if (score >= 6)
        {
            score = 7;
        } else
        {
            score += amount;
        }
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
