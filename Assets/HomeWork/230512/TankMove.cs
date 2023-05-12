using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankMove : MonoBehaviour
{
    /// <summary>
    /// OnMove�� ���� ������ Vector�� ������ Vector3
    /// </summary>
    private Vector3 dir;

    /// <summary>
    /// �̵��ӵ��� ȸ���ӵ�
    /// </summary>
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float spinSpeed = 5f;

    /// <summary>
    /// �����Ӵ����� Move�� Rotate ȣ��
    /// </summary>
    private void Update()
    {
        Move();
        Rotate();
    }

    /// <summary>
    /// ȸ�� �������� ���Ͽ� Move���� ��,�ڷθ� �̵� ������ ���ְ�
    /// </summary>
    private void Move()
    {
        transform.Translate(Vector3.forward * dir.z * moveSpeed * Time.deltaTime, Space.Self);
    }

    /// <summary>
    /// Rotate���� ��,�� ������Ʈ�� ȸ�� �����ش�.
    /// </summary>
    private void Rotate()
    {
        transform.Rotate(Vector3.up,dir.x * Time.deltaTime * spinSpeed, Space.World);
    }

    /// <summary>
    /// �̵� ��ư�� ������ �� ȣ��Ǵ� �Լ�
    /// </summary>
    /// <param name="value"></param>
    private void OnMove(InputValue value)
    {
        dir.x = value.Get<Vector2>().x;
        dir.z = value.Get<Vector2>().y; 
    }
}
