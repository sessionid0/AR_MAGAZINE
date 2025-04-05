using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWithUp : MonoBehaviour
{
    public float rotationSpeed = 15f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
            Vector3 currentPosition = transform.position;
            transform.position = currentPosition;
        }
    }
}
