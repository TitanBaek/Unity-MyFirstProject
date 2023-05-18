using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private int shootCount;                        // ��ź �߻� �� ī��Ʈ Int
    public Action<int> OnChangedCount;                              // �Ű������� int�� ���� delegate 
    public int ShootCount {  get { return shootCount;  } }          // ��ź �߻� �� Getter

    public void AddShootCount(int count)
    {
        shootCount += count;
        OnChangedCount?.Invoke(count);
    }
}
