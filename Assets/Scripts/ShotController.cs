using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float maxShotPower = 25f;
    public BallController ballController;

    private bool canShot = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ballController.ShotBall(maxShotPower);
            }
        }
    }
}
