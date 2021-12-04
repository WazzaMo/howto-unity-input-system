using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[AddComponentMenu("InputExample/" + nameof(MotionInput))]
[RequireComponent(typeof(PlayerInput))]
public class MotionInput : MonoBehaviour
{
    [Header("Debug Visibility")]
    public Vector2 _ForwardBackward;
    public Vector2 _AngularRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnFwdBwd(InputValue input)
    {
        _ForwardBackward = input.Get<Vector2>();
        Debug.Log($"OnFwdBwd - {_ForwardBackward.x}, {_ForwardBackward.y}");
    }

    void OnRotate(InputValue input)
    {
        _AngularRotation = input.Get<Vector2>();
        Debug.Log($"OnRotate - {_AngularRotation.x}, {_AngularRotation.y}");
    }
}
