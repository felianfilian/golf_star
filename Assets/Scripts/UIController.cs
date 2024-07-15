using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Slider sliderPower;
    public GameObject txtWin;
    public TMP_Text txt_shots;

    private void Awake()
    {
        instance = this;
        txtWin.SetActive(false);
    }

    public void UpdatePowerUI(float power, float maxPower)
    {
        sliderPower.maxValue = maxPower;
        sliderPower.value = power; 
    }

    public void UpdateShotCount(int shots)
    {
        txt_shots.text = "Shots: " + shots;
    }


    public void ShowWinText()
    {
        txtWin.SetActive(true); 
    }
}
