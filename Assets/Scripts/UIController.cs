using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Slider sliderPower;

    public void ChangePowerUI(float power, float maxPower)
    {
        sliderPower.maxValue = maxPower;
        sliderPower.value = power; 
    }
}
