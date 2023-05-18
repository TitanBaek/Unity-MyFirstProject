using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting
{
    // static 함수 바로 앞에 선언해주면 static함수를 게임이 실행되자 마자 실행해줌.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        if(GameManager.Instance == null)                                            // 게임매니저가 없는 경우
        {
            GameObject gameManager = new GameObject() { name = "GameManager" } ;    // 게임 매니저 컴포넌트(현 스크립트)를 담을 게임 오브젝트 생성
            gameManager.AddComponent<GameManager>();                                // 게임 오브젝트에 컴포넌트를 삽입.
        }
    }
}
