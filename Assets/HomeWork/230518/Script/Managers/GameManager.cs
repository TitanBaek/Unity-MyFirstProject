using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static DataManager dataManager;

    public static GameManager Instance { get { return instance; } }         // ���ӸŴ��� Instance Getter
    public static DataManager Data { get { return dataManager; } }          // �����͸Ŵ��� Instance Getter

    private void Awake()                                                    // ���� ���� ��
    {
        if(instance != null)                                                // ���� ���� ���� static�� GameManager instance�� �����ϴ��� Ȯ��
        {
            Destroy(this);                                                  // �ִٸ�, ���� ������Ʈ�� ��Ʈ���� �Ѵ�.
            return;                                                         // return;
        }
        instance = this;                                                    // ���ٸ� instance�� this�� ���־� GameManager �� �������ְ�
        DontDestroyOnLoad(this);                                            // DontDestroyOnLoad(this)�� ���־� �� �̵��� �̷������ �ı����� �ʴ� ������Ʈ�� �����Ѵ�.
        InitManagers();                                                     // ���� �Ŵ����� �ʱ�ȭ �۾� 
    }

    private void InitManagers()
    {
        GameObject dataObj = new GameObject() { name = "DataManager" };     // DataManager �� ���� ���ӿ�����Ʈ ����
        dataObj.transform.SetParent(transform);                             // ������ ������Ʈ�� GameManager�� �ڽ� ������Ʈ�� ���� 
        dataManager = dataObj.AddComponent<DataManager>();                  // ������ ������Ʈ�� DataManager ������Ʈ�� ����
    }

    private void OnDestroy()                                                // ������Ʈ�� ��Ʈ���� �Ǹ� instance �� �� null�� ���� �ٲ���
    {
        if(instance == this)
            instance = null;
    }
}
