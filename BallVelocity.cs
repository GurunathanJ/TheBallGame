using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 VecValue;
     // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += VecValue;
    }
}
