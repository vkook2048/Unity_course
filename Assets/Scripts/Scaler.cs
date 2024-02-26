using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        transform.localScale += new Vector3(1 * speed, 1 * speed, 1 * speed);
    }
}
