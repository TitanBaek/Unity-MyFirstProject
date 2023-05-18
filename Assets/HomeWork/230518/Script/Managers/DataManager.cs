using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private int shootCount;                        // 포탄 발사 수 카운트 Int
    public Action<int> OnChangedCount;                              // 매개변수로 int를 받을 delegate 
    public int ShootCount {  get { return shootCount;  } }          // 포탄 발사 수 Getter

    public void AddShootCount(int count)
    {
        shootCount += count;
        OnChangedCount?.Invoke(count);
    }
}
