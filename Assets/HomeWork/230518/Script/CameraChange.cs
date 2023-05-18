using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraChange : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera normal;               // �븻��
    [SerializeField] private CinemachineVirtualCamera aim;                  // ���غ�

    public void OnAim(InputValue value)                                     // ����Ʈ�� ���� �� ���غ��, ����Ʈ���� ���� ���� ��ֺ�� Priority�� �����ϴ� ����
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
