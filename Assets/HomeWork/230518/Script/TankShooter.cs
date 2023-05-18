using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TankShooter : MonoBehaviour
{
    public UnityEvent onFired;                                  // 유니티 이벤트
    private Coroutine coroutine;                                // 연속 발사를 담을 코루틴
    [SerializeField ] private BulletMover bullet;               // 발사될 포탄의 게임 오브젝트(여기선 BulletMover라는 컴포넌트 명으로 지정함)
    [SerializeField] private Transform bulletStart;             // 포탄이 발사될 게임오브젝트의 Transform!
    [SerializeField] private float repeatSpeed;                 // 연속발사 속도(초)


    private void OnRepeatFire(InputValue value)                 // 스페이스바가 눌릴 경우 호출 됨
    {
        if (value.isPressed)                                    // 꾸욱 눌리고 있다.
        {
            coroutine = StartCoroutine(OnFire());               // 코루틴 시작
        } else                                                  // 스페이스바에서 손을 땠다
        {
            StopCoroutine(coroutine);                           // 코루틴 종료
        }
    }

    private IEnumerator OnFire()                                // 연속 발사 코루틴
    {
        while (true)
        {
            Fire();                                             // 발사 함수 실행
            yield return new WaitForSeconds(repeatSpeed);       // 발사 딜레이
        }
    }

    public void Fire()
    {
        Instantiate(bullet, bulletStart.position, bulletStart.rotation);            // 포탄을 포탄생성지점의 포지션과 각도에 생성
        GameManager.Data.AddShootCount(1);                                          // DataManager(Model)의 AddShootCount를 1과 함께 호출
        onFired?.Invoke();                                                          // onFired 이벤트 실행
    }



}
