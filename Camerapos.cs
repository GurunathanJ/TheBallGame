using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerapos : MonoBehaviour
{
    [SerializeField]
    Transform BallPos;
    void Update()
    {
        transform.position=BallPos.position;
    }
}
