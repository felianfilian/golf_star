using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public static ShotController instance;

    public BallController ballController;

    public float minShotPower = 5f;
    public float maxShotPower = 25f;
    public bool canShot = true;
    public float activeShotPower;
    public float powerChangeSpeed = 30f;
    public bool powerGrowing = true;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (canShot)
        {
            if (activeShotPower >= maxShotPower) 
            {
                powerGrowing = false;
            } else if(activeShotPower <= minShotPower)
            {
                powerGrowing = true;
            }

            if (powerGrowing)
            {
                activeShotPower = Mathf.MoveTowards(activeShotPower, maxShotPower, powerChangeSpeed * Time.deltaTime);
            }
            else
            {
                activeShotPower = Mathf.MoveTowards(activeShotPower, minShotPower, powerChangeSpeed * Time.deltaTime);
            }

            if (Input.GetMouseButtonDown(0))
            {
                ballController.ShotBall(activeShotPower);
                GameManager.Instance.CountShot();
            }

            UIController.instance.UpdatePowerUI(activeShotPower, maxShotPower);
        }
    }

    public void ResetShotPower()
    {
        activeShotPower = minShotPower;
    }
}
