using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 _rotateDirection = new Vector3(0, 0.5f, 0);

    void Update()
    {
        transform.Rotate(_rotateDirection);
    }
}
