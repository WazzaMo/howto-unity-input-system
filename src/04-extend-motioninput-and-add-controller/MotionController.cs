using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("InputExample/" + nameof(MotionController))]
[RequireComponent(typeof(MotionInput))]
public class MotionController : MonoBehaviour
{
    [Header("Speed Factor for Forward / Backward - metres per second")]
    public float _MotionSpeedPerSecond = 2.0f;

    [Header("Rotational speed in degrees per second")]
    public float _AngularSpeedPerSecond = 15f;

    private MotionInput _Input;
    private Transform _Transform;

    void Start()
    {
        _Input = GetComponent<MotionInput>();
        _Transform = GetComponent<Transform>();
    }

    void Update()
    {
        MoveForwardBackward();
        RotateAroundYAxis();
    }

    private void MoveForwardBackward()
    {
        float zPosDelta = _Input._ForwardBackward.y * _MotionSpeedPerSecond * Time.deltaTime;
        _Transform.Translate(0, 0, zPosDelta);
    }

    private void RotateAroundYAxis()
    {
        float angularDelta = _Input._AngularRotation.x * _AngularSpeedPerSecond * Time.deltaTime;
        _Transform.Rotate(0, angularDelta, 0);
    }
}
