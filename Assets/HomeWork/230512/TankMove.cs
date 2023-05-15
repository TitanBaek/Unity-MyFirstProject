using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankMove : MonoBehaviour
{
    /// <summary>
    /// OnMove로 부터 들어오는 Vector를 저장할 Vector3
    /// </summary>
    private Vector3 dir;

    /// <summary>
    /// 이동속도와 회전속도
    /// </summary>
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float spinSpeed = 5f;

    [Header("Shooter")]
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private float repeatTime;

    /// <summary>
    /// 프레임단위로 Move와 Rotate 호출
    /// </summary>
    private void Update()
    {
        Move();
        Rotate();
    }

    /// <summary>
    /// 회전 구현으로 인하여 Move에선 앞,뒤로만 이동 동작을 해주고
    /// </summary>
    private void Move()
    {
        transform.Translate(Vector3.forward * dir.z * moveSpeed * Time.deltaTime, Space.Self);
    }

    /// <summary>
    /// Rotate에선 좌,우 오브젝트를 회전 시켜준다.
    /// </summary>
    private void Rotate()
    {
        transform.Rotate(Vector3.up,dir.x * Time.deltaTime * spinSpeed, Space.World);
    }

    /// <summary>
    /// 이동 버튼이 눌렸을 때 호출되는 함수
    /// </summary>
    /// <param name="value"></param>
    private void OnMove(InputValue value)
    {
        dir.x = value.Get<Vector2>().x;
        dir.z = value.Get<Vector2>().y; 
    }

    private Coroutine bulletRoutine; // 총알 생성 루틴

    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation); // 씬에 Prefab 추가, GameObject를 반환하는 메소드다
            yield return new WaitForSeconds(repeatTime);
        }
    }
    private void OnFire(InputValue value)
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation); // 씬에 Prefab 추가, GameObject를 반환하는 메소드다
    }

    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        } else
        {
            StopCoroutine(bulletRoutine);
        }
    }
}
