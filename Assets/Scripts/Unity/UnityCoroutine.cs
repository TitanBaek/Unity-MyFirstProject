using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCoroutine : MonoBehaviour
{
    // �ڷ�ƾ�� ���� �߿��մϴ�..

    /************************************************************************
	 * �ڷ�ƾ (Coroutine)
	 * 
	 * �۾��� �ټ��� �����ӿ� �л��� �� �ִ� �񵿱�� �۾�
	 * �ݺ������� �۾��� �л��Ͽ� �����ϸ�, ������ �Ͻ������ϰ� �ߴ��� �κк��� �ٽý����� �� ����
	 * ��, �ڷ�ƾ�� �����尡 �ƴϸ� �ڷ�ƾ�� �۾��� ������ ���� �����忡�� ����
	 ************************************************************************/

    // <�ڷ�ƾ ����>
    // �ݺ������� �۾��� StartCorouine�� ���� ����

    // �ڷ�ƾ�� �⺻ �����

    private Coroutine routine;

    private void Start()
    {
        //CorutineStart();
    }

    /*
    private void CorutineStart()
    {
        routine = StartCoroutine(SubRoutine());
    }
    */
    private void CoroutineStop()
    {
        StopCoroutine(routine);             // Ư�� �ڷ�ƾ ���߱�
        StopAllCoroutines();                // �� ��ũ��Ʈ�� ��� �ڷ�ƾ ���߱�
    }

    /*

    IEnumerator SubRoutine()
    {
        //yield return new WaitForSeconds(3f);
        //Debug.Log("�α����");
        for(int i = 0; i < 10; i++) {
            Debug.Log($"{i}�� ����");
            yield return new WaitForSeconds(1f);        // WaitForSeconds(�ð�) ����ϴ� �޼ҵ�
        }
        
    }
*/
    // <�ڷ�ƾ �ð� ����>
    // �ڷ�ƾ�� �ð� ������ �����Ͽ� �ݺ� ������ �۾��� ���� Ÿ�̹��� ������ �� ����
    IEnumerator CoRoutineWait()
    {
        yield return new WaitForSeconds(1); //n�ʰ� �ð�����
        yield return null;                  // �ð� ���� ����
    }
}
