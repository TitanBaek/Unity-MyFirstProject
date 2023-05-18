using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class GameManager0 : MonoBehaviour
{
    private static GameManager instance;
    private static DataManager dataManager;

    public static GameManager Instance { get { return instance; } }
    public static DataManager Data { get { return dataManager; } }

    // Unity 전용 싱글톤 만드는 방식
    // 1. 

    private void Awake()
    {

        if(instance != null)
        {
            Destroy(this);
            return;
        }

        DontDestroyOnLoad(this);
        instance = this;
        InitManagers();
    }

    private void InitManagers()
    {
        // 데이터 매니저 초기화
        // this(GameManager)의 자식 오브젝트로 데이터 매니저를 추가해줌
        GameObject dataobj = new GameObject() { name = "DataManager" };
        dataobj.transform.SetParent(transform);
        dataManager = dataobj.AddComponent<DataManager>();  
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null; 
        }
    }
}

*/