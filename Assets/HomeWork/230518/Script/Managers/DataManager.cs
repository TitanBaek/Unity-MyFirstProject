using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    [SerializeField] private int shootCount;                        // 포탄 발사 수 카운트 Int
    public Action<int> OnChangedCount;                              // 매개변수로 int를 받을 delegate 
    public int ShootCount {  get { return shootCount;  } }          // 포탄 발사 수 Getter

    public void AddShootCount(int count)                            // 발사 시에 호출되는 함수인데
    {
        shootCount += count;                                        // shootCount를 증감시키고
        OnChangedCount?.Invoke(shootCount);                         // 매개변수 shootCount로 이벤트 실행
    }
}
