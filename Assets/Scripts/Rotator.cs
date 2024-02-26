using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateDirection;

    private void Update()
    {
        transform.Rotate(_rotateDirection);
    }
}
