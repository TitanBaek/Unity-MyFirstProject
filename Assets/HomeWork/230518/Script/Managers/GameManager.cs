using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static DataManager dataManager;

    public static GameManager Instance { get { return instance; } }         // 게임매니저 Instance Getter
    public static DataManager Data { get { return dataManager; } }          // 데이터매니저 Instance Getter

    private void Awake()                                                    // 게임 실행 시
    {
        if(instance != null)                                                // 현재 게임 내에 static의 GameManager instance가 존재하는지 확인
        {
            Destroy(this);                                                  // 있다면, 현재 컴포넌트를 디스트로이 한다.
            return;                                                         // return;
        }
        instance = this;                                                    // 없다면 instance를 this로 해주어 GameManager 를 생성해주고
        DontDestroyOnLoad(this);                                            // DontDestroyOnLoad(this)를 해주어 씬 이동이 이루어져도 파괴되지 않는 오브젝트로 지정한다.
        InitManagers();                                                     // 각종 매니저들 초기화 작업 
    }

    private void InitManagers()
    {
        GameObject dataObj = new GameObject() { name = "DataManager" };     // DataManager 를 담을 게임오브젝트 생성
        dataObj.transform.SetParent(transform);                             // 생성된 오브젝트를 GameManager의 자식 오브젝트로 지정 
        dataManager = dataObj.AddComponent<DataManager>();                  // 생성된 오브젝트에 DataManager 컴포넌트를 삽입
    }

    private void OnDestroy()                                                // 컴포넌트가 디스트로이 되면 instance 또 한 null로 값을 바꿔줌
    {
        if(instance == this)
            instance = null;
    }
}
