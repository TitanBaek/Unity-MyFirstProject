using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCoroutine : MonoBehaviour
{
    // 코루틴이 정말 중요합니다..

    /************************************************************************
	 * 코루틴 (Coroutine)
	 * 
	 * 작업을 다수의 프레임에 분산할 수 있는 비동기식 작업
	 * 반복가능한 작업을 분산하여 진행하며, 실행을 일시정지하고 중단한 부분부터 다시시작할 수 있음
	 * 단, 코루틴은 스레드가 아니며 코루틴의 작업은 여전히 메인 스레드에서 실행
	 ************************************************************************/

    // <코루틴 진행>
    // 반복가능한 작업을 StartCorouine을 통해 실행

    // 코루틴의 기본 사용방법

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
        StopCoroutine(routine);             // 특정 코루틴 멈추기
        StopAllCoroutines();                // 현 스크립트의 모든 코루틴 멈추기
    }

    /*

    IEnumerator SubRoutine()
    {
        //yield return new WaitForSeconds(3f);
        //Debug.Log("로그찍기");
        for(int i = 0; i < 10; i++) {
            Debug.Log($"{i}초 지남");
            yield return new WaitForSeconds(1f);        // WaitForSeconds(시간) 대기하는 메소드
        }
        
    }
*/
    // <코루틴 시간 지연>
    // 코루틴은 시간 지연을 정의하여 반복 가능한 작업의 진행 타이밍을 지정할 수 있음
    IEnumerator CoRoutineWait()
    {
        yield return new WaitForSeconds(1); //n초간 시간지연
        yield return null;                  // 시간 지연 없음
    }
}
