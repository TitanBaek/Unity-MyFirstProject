using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMover : MonoBehaviour
{
    private Vector3 moveDir;                                
    [SerializeField] private float moveSpeed;                   // �̵��ӵ�
    [SerializeField] private float rotateSpeed;                 // ȸ���ӵ�

    private void Update()                                       // ������ ������ Move�� Rotate ȣ���Ͽ� ��ũ�� �̵� �Ǵ� ȸ����Ŵ
    {
        Move();
        Rotate();
    }

    private void Move()                                         // �̵� ����
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime);
    }
    private void Rotate()                                       // ȸ�� ����
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }
    private void OnMove(InputValue value)                       // �̵�Ű�� ������ �� ȣ�� ��
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
}
