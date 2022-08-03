using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    void Update()
    {
        transform.Rotate(120 * speed * Time.deltaTime, 90 * speed * Time.deltaTime, 180 * speed * Time.deltaTime);
    }
}
