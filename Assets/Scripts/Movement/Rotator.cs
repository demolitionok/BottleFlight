using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1f;
    
    private Vector3 _vectorToRotate = Vector3.zero;
    private Rigidbody _rb;

    public void OnJoystick(InputAction.CallbackContext ctx)
    {
        Vector2 val = ctx.ReadValue<Vector2>();
        Vector3 rotateVector = new Vector3(val.x, val.y, 0).normalized;
        _vectorToRotate = (Vector3.forward + rotateVector).normalized;
        
        if(_vectorToRotate != Vector3.forward)
            RotateToDirection(_vectorToRotate);
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    private void RotateToDirection(Vector3 vectorToRotate)
    {
        var towardRotation = Vector3.RotateTowards(transform.forward, vectorToRotate, rotationSpeed, 0f);
        var resultRotation = Quaternion.LookRotation(towardRotation);
        
        _rb.MoveRotation(resultRotation);
    }
}
