using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Slider sliderPower;
    public GameObject txtWin;
    public GameObject txtOut;

    public TMP_Text txt_score;
    public TMP_Text txt_shots;
    public GameObject resultScreen;
    public TMP_Text txtResult;

    private int newScore = 0;

    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        txtWin.SetActive(false);
        resultScreen.SetActive(false);
    }


    public void UpdatePowerUI(float power, float maxPower)
    {
        sliderPower.maxValue = maxPower;
        sliderPower.value = power; 
    }

    public void UpdateScoreCount(int score)
    {
        txt_score.text = "Score: " + score;
    }

    public void UpdateShotCount(int shots)
    {
        txt_shots.text = "Shots: " + shots;
    }


    public void ShowWinText()
    {
        txtWin.SetActive(true); 
    }

    public void ShowOutText()
    {
        txtOut.SetActive(true);
    }

    public void HideOutText()
    {
        txtOut.SetActive(false);
    }

    public void ShowResultScreen(int scoreResult)
    {
        newScore = scoreResult + GameManager.instance.fullScore;
        txtResult.text = GameManager.instance.fullScore + " + " + scoreResult.ToString() + " = " + newScore;
        txtWin.SetActive(false);
        resultScreen.SetActive(true);
    }

    // Buttons

    public void MainMenu()
    {
        SceneManager.LoadScene(GameManager.instance.mainMenuScene);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextCourse()
    {
        PlayerPrefs.SetString("actual_course", GameManager.instance.nextLevelScene);
        PlayerPrefs.SetInt("full_score", newScore);
        SceneManager.LoadScene(GameManager.instance.nextLevelScene);
    }
}
