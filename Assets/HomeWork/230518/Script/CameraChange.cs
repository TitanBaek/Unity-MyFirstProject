using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera normal;               // 노말뷰
    [SerializeField] private CinemachineVirtualCamera aim;                  // 조준뷰

    public void OnAim(InputValue value)                                     // 쉬프트가 눌릴 땐 조준뷰로, 쉬프트에서 손을 때면 노멀뷰로 Priority를 세팅하는 로직
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
