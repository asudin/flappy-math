using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [Header("Move Settings")]
    public float speed;

    void Start()
    {
        
    }

    // moves the objects
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
