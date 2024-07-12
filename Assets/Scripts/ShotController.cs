using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public static ShotController instance;

    public BallController ballController;

    public float maxShotPower = 25f;
    public bool canShot = true;

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
            if (Input.GetMouseButtonDown(0))
            {
                ballController.ShotBall(maxShotPower);
            }
        }
    }
}
