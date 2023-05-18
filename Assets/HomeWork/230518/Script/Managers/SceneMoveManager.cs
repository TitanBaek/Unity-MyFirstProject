using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{

    public void DoSceneMove(string name)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(name);

        asyncOperation.allowSceneActivation = true;     // 씬 로딩 완료시 바로 씬 로드를 진행하는지 여부
        bool isLoad = asyncOperation.isDone;            // 씬 로딩이 완료되었는지 판단
        float progress = asyncOperation.progress;       // 씬 로딩률 확인
        asyncOperation.completed += (oper) => { };      // 씬 로딩 완료시 진행할 이벤트 추가

    }
}
