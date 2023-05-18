using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{

    public void DoSceneMove(string name)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(name);

        asyncOperation.allowSceneActivation = true;     // �� �ε� �Ϸ�� �ٷ� �� �ε带 �����ϴ��� ����
        bool isLoad = asyncOperation.isDone;            // �� �ε��� �Ϸ�Ǿ����� �Ǵ�
        float progress = asyncOperation.progress;       // �� �ε��� Ȯ��
        asyncOperation.completed += (oper) => { };      // �� �ε� �Ϸ�� ������ �̺�Ʈ �߰�

    }
}
