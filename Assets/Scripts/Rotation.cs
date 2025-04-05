using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        //Rotate the object to the right relative to its own center point
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
