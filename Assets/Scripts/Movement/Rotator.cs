using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{
    public void OnJoystick(InputAction.CallbackContext ctx)
    {
        Vector2 val = ctx.ReadValue<Vector2>();
        Vector3 rotateVector = new Vector3(val.x, val.y, 0);
        gameObject.transform.Rotate(rotateVector);
    }
}
