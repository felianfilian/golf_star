using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public Transform verticalPoint;

    public float moveSpeed = 5f;
    
    private Vector3 offest;
    private float rotation;
    private float verticalRotation;



    void Start()
    {
        offest = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offest;
        rotation += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(18f, rotation, 0);
    }
}
