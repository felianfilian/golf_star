using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    
    public float hitpower = 25f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            rb.velocity = Vector3.forward * hitpower;
        }

        if(rb.velocity.magnitude < 2)
        {

        }
    }
}
