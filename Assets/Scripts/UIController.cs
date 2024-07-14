using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Slider sliderPower;
    public GameObject txtWin;

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

    public void ShowWinScreen()
    {
        txtWin.SetActive(true); 
    }
}
