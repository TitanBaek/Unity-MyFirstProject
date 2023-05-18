using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] private int shootCount;                        // ��ź �߻� �� ī��Ʈ Int
    public Action<int> OnChangedCount;                              // �Ű������� int�� ���� delegate 
    public int ShootCount {  get { return shootCount;  } }          // ��ź �߻� �� Getter

    public void AddShootCount(int count)                            // �߻� �ÿ� ȣ��Ǵ� �Լ��ε�
    {
        shootCount += count;                                        // shootCount�� ������Ű��
        OnChangedCount?.Invoke(shootCount);                         // �Ű����� shootCount�� �̺�Ʈ ����
    }
}
