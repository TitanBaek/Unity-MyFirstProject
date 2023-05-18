using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private int shootCount;
    public Action<int> OnChangedCount;
    public int ShootCount {  get { return shootCount;  } }

    public void AddShootCount(int count)
    {
        shootCount += count;
        OnChangedCount?.Invoke(count);
    }
}
