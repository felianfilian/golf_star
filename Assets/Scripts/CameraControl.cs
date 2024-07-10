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

    private void Start()
    {
        verticalRotation = verticalPoint.localRotation.eulerAngles.x;
    }

    void Update()
    {
        transform.position = target.position;
        
        rotation += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        verticalRotation += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, 0f, 75f);
        
        transform.rotation = Quaternion.Euler(0f, rotation, 0f);
        verticalPoint.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
