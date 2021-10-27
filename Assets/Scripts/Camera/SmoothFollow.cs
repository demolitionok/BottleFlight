using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float smoothingSpeed;

    private Vector3 _velocity = Vector3.zero;
    
    private void FixedUpdate()
    {
        var targetPos = target.position;
        var resultPos = targetPos + offset;
        resultPos = Vector3.SmoothDamp(resultPos, targetPos, ref _velocity, smoothingSpeed);
        transform.position = resultPos;
    }
}
