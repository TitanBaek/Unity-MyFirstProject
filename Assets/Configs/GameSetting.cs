using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSetting
{
    // 0. static �Լ� �ٷ� �տ� �������ָ� static�Լ��� ������ ������� ���� ��������.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    // 1. �ʱ�ȭ ������ �����ϱ��� �ʿ��� �������� Init�Լ����� �ǽ�����.
    private static void Init()
    {
        // �� ���� ���� GameManager�� ������ GameManager ������Ʈ�� ���� ���� ������Ʈ �߰�
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = "GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}
