using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public static BallController instance;

    public Rigidbody rb;
    public new CameraControl camera;

    public float hitpower = 25f;
    public float stopCutoff = 1.75f;
    public float stopSpeed = 0.95f;
    public bool outOfBounds;

    [HideInInspector]
    public Vector3 lastBallPosition;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastBallPosition = transform.position;
    }

    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F)) 
        //{
        //    // rb.velocity = Vector3.forward * hitpower;
        //    rb.velocity = camera.transform.forward * hitpower;
        //    camera.HideIndicator();
        //}

        if(rb.velocity.y > -0.01f)
        {
            if (rb.velocity.magnitude < stopCutoff)
            {
                rb.velocity *= stopSpeed;
                if (rb.velocity.magnitude < 0.01f)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                    
                    if (!CupController.instance.ballInCup && !outOfBounds)
                    {
                        ShotController.instance.canShot = true;
                        lastBallPosition = transform.position;
                        camera.ShowIndicator();
                        UIController.instance.sliderPower.gameObject.SetActive(true);
                    }
                }
            }
        } 
        
    }

    public void ShotBall(float shotForce)
    {
        ShotController.instance.canShot = false;
        rb.velocity = camera.transform.forward * shotForce;
        camera.HideIndicator();
        ShotController.instance.ResetShotPower();
        UIController.instance.sliderPower.gameObject.SetActive(false);
    }

    public void ResetBallPosition()
    {
        rb.Move(lastBallPosition, transform.rotation);
    }
}
