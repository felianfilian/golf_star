using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public Transform verticalPoint;

    public bool useMouseRotation = false;
    public float moveSpeed = 180f;
 
    private float rotation;
    private float verticalRotation;

    private void Start()
    {
        verticalRotation = verticalPoint.localRotation.eulerAngles.x;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        transform.position = target.position;

        if(useMouseRotation)
        {
            rotation += Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
            verticalRotation += Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;
        } else
        {
            rotation += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            verticalRotation += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        }
       
        verticalRotation = Mathf.Clamp(verticalRotation, 0f, 75f);
        
        transform.rotation = Quaternion.Euler(0f, rotation, 0f);
        verticalPoint.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
