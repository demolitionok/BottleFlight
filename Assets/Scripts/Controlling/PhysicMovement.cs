using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicMovement : MonoBehaviour
{
    [SerializeField]
    private Transform forcePoint;
    [SerializeField]
    private float forceModifier;
    
    private Rigidbody _rigidbody;
    private Vector3 _direction;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _direction = Vector3.forward;
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForceAtPosition(_direction * forceModifier, forcePoint.position, ForceMode.Force);
    }
}
