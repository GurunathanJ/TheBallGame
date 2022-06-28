using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField]
    Vector3 VecValue;
    [SerializeField]
    KeyCode Left;
    [SerializeField]
    KeyCode Right;

     // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(Right))
        GetComponent<Rigidbody>().velocity += VecValue;

        if (Input.GetKey(Left))
        GetComponent<Rigidbody>().velocity -= VecValue;
    }
}
