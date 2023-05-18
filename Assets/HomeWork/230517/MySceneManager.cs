using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public void MoveScene(string sceneName)
    {
        // 비동기 씬 로드 : 백그라운드로 씬을 로딩하도록 하여 게임 중 멈춤이 없도록 함
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        asyncOperation.allowSceneActivation = true;     // 씬 로딩 완료시 바로 씬 로드를 진행하는지 여부
        bool isLoad = asyncOperation.isDone;            // 씬 로딩이 완료되었는지 판단
        float progress = asyncOperation.progress;       // 씬 로딩률 확인
        asyncOperation.completed += (oper) => { };      // 씬 로딩 완료시 진행할 이벤트 추가
    }
}
