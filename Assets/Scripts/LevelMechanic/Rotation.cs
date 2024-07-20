using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotateSpeed = 30f;

    void Update()
    {

        transform.Rotate(0,0, rotateSpeed * Time.deltaTime);
    }
}
