using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Update()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed);
    }
}
