using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;

    public float moveSpeed;
    
    private Vector3 offest;
    private float rotation;


    void Start()
    {
        offest = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offest;
    }
}
