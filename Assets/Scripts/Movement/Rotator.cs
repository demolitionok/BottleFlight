using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{
    private Vector3 _vectorToRotate = Vector3.zero;
    public void OnJoystick(InputAction.CallbackContext ctx)
    {
        Vector2 val = ctx.ReadValue<Vector2>();
        Vector3 rotateVector = new Vector3(val.y, val.x, 0).normalized; 
        _vectorToRotate = (Vector3.forward + rotateVector).normalized;
    }

    public void FixedUpdate()
    {
        gameObject.transform.Rotate(_vectorToRotate);
    }
}
