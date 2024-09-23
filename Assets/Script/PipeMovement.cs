using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private float _speed = 0.65f;
    private void Start()
    {
        
    }

    
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
