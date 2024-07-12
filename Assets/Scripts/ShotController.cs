using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public static ShotController instance;

    public BallController ballController;

    public float maxShotPower = 25f;
    public bool canShot = true;
    public float activeShotPower;
    public float powerChangeSpeed = 15f;
    public bool powerGrowing = true;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShot)
        {
            if (activeShotPower >= maxShotPower) 
            {
                powerGrowing = false;
            } else if(activeShotPower <= 0f)
            {
                powerGrowing = true;
            }

            if (powerGrowing)
            {
                activeShotPower = Mathf.MoveTowards(activeShotPower, maxShotPower, powerChangeSpeed * Time.deltaTime);
            }
            else
            {
                activeShotPower = Mathf.MoveTowards(activeShotPower, 0f, powerChangeSpeed * Time.deltaTime);
            }

            if (Input.GetMouseButtonDown(0))
            {
                ballController.ShotBall(activeShotPower);
            }
        }
    }
}
