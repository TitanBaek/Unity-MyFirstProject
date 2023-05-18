using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera normal;
    [SerializeField] private CinemachineVirtualCamera aim;

    public void OnAim(InputValue value)
    {
        if (value.isPressed)
        {
            normal.Priority = 1;
            aim.Priority = 2;
        } else
        {
            aim.Priority = 1;
            normal.Priority = 2;
        }
    }
}
