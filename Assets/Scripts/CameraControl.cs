using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public Transform verticalPoint;

    public float moveSpeed = 5f;
 
    private float rotation;
    private float verticalRotation;



    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
        //rotation += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(18f, rotation, 0);
    }
}
