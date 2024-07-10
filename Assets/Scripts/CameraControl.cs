using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public Transform verticalPoint;

    public float moveSpeed = 180f;
 
    private float rotation;
    private float verticalRotation;



    void Update()
    {
        transform.position = target.position;
        rotation += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        verticalRotation += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, rotation, 0f);
        verticalPoint.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
