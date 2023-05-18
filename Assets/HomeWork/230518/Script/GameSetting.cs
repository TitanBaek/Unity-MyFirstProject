using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting
{
    // static �Լ� �ٷ� �տ� �������ָ� static�Լ��� ������ ������� ���� ��������.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        if(GameManager.Instance == null)                                            // ���ӸŴ����� ���� ���
        {
            GameObject gameManager = new GameObject() { name = "GameManager" } ;    // ���� �Ŵ��� ������Ʈ(�� ��ũ��Ʈ)�� ���� ���� ������Ʈ ����
            gameManager.AddComponent<GameManager>();                                // ���� ������Ʈ�� ������Ʈ�� ����.
        }
    }
}
