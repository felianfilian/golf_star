using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public CameraControl camera;
    public GameObject directionIndicator;

    public float hitpower = 25f;
    public float stopCutoff = 1.75f;
    public float stopSpeed = 0.95f;

    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            // rb.velocity = Vector3.forward * hitpower;
            rb.velocity = camera.transform.forward * hitpower;
        }

        if(rb.velocity.y > -0.01f)
        {
            if (rb.velocity.magnitude < stopCutoff)
            {
                rb.velocity *= stopSpeed;
                if (rb.velocity.magnitude < 0.01f)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
        } 
        
    }
}
