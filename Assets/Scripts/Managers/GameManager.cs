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

    // Unity ���� �̱��� ����� ���
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
        // ������ �Ŵ��� �ʱ�ȭ
        // this(GameManager)�� �ڽ� ������Ʈ�� ������ �Ŵ����� �߰�����
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