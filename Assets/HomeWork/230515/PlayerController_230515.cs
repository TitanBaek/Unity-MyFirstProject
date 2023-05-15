using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController_230515 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;                   // 탱크의 이동속도 ( transform )
    [SerializeField] private float rotateSpeed;                 // 탱크의 회전속도 ( transform )
    private Vector3 moveDir;                                    // 키 입력에 따른 위치/각도 조정 값을 담을 Vector3

    [SerializeField] private Bullet_230515 bulletPrefab;        // 총알 Prefab
    [SerializeField] private Transform bulletStart_pos;         // 총알이 발사 될 게임 오브젝트의 Transform
    [SerializeField] private float fireSpeed;                   // 포탄 발사간 딜레이(코루틴에 들어갈 값)

    private Coroutine bulletCoroutine;                          // 포탄 연속 발사를 구현하기 위한 코루틴을 담을 코루틴 자료형의 변수

    IEnumerator RepeatFire()                                    // 연속 발사 코루틴 
    {
        while (true)                                                                                // 계속해서 반복
        {
            Instantiate(bulletPrefab, bulletStart_pos.position, bulletStart_pos.rotation);          // 포탄 Prefab과 생성 위치와 각도를 매개변수로 하여 프리팹 인스턴스 생성
            yield return new WaitForSeconds(fireSpeed);                                             // fireSpeed 만큼 딜레이을 줌

        }
    }
    private void Update()                                                                           // 프레임단위로 이동과 회전 함수 호출
    {
        Move();
        Rotate();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime, Space.Self);  // 탱크 이동 구현
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.Self);        // 탱크 회전 구현 
    }
    
    void OnMove(InputValue value)                                                                  // 이동 Key 입력이 되었을 때 호출되는 메소드
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }

    void OnRepeatFire(InputValue value)                                                            // 연사 버튼(마우스 왼쪽)이 입력 되었을 때 호출되는 메소드
    {
        if (value.isPressed)                                                                       // .isPressed 는 현재 눌리고 있는 상태를 뜻함
        {
            bulletCoroutine = StartCoroutine(RepeatFire());
        } else                                                                                     // 버튼이 눌렸다가 때어졌을 때
        {
            StopCoroutine(bulletCoroutine);
        }
    }

    void OnFire(InputValue value)                                                                   // 일반 발사(Space)가 눌렸을 때 호출되는 메소드 
    {
        Instantiate(bulletPrefab, bulletStart_pos.position, bulletStart_pos.rotation);
    }
}
