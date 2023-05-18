using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMover : MonoBehaviour
{
    private Vector3 moveDir;                                
    [SerializeField] private float moveSpeed;                   // 이동속도
    [SerializeField] private float rotateSpeed;                 // 회전속도

    private void Update()                                       // 프레임 단위로 Move와 Rotate 호출하여 탱크를 이동 또는 회전시킴
    {
        Move();
        Rotate();
    }

    private void Move()                                         // 이동 구현
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime);
    }
    private void Rotate()                                       // 회전 구현
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }
    private void OnMove(InputValue value)                       // 이동키가 눌렸을 때 호출 됨
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
}
