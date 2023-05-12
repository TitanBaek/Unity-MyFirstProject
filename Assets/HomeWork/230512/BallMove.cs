using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class BallMove : MonoBehaviour
{
    private Rigidbody rb;           // Addforce �� �������� �� ������ �ٵ� 
    private Vector3 dir;            // Ű �Է¿� ���� ���� �Ű��� x,y,z �� ���� Vector3

    /// <summary>
    /// �̵��ϴ� ���� �����ϴ� �� 
    /// </summary>
    [SerializeField]
    private float movePower = 1f;
    [SerializeField]
    private float jumpPower = 1f; 

    /// <summary>
    /// ���� ���� �� ������ٵ� ������Ʈ ��������
    /// </summary>
    private void Awake()
    {
       rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// ��  �����Ӹ��� ĳ���� ������ ���� �ľ��Ͽ� �̵� �Լ� ȣ��
    /// </summary>
    private void Update()
    {
        Move();
    }
    
    /// <summary>
    /// InputSystem ���� Ű �Է¿� ���� ���� ������ Vector3 dir * �̵������ rb�� ���� ���� ���� �̵��� ������
    /// </summary>
    private void Move()
    {
        rb.AddForce(dir * movePower);
    }

    /// <summary>
    /// ������ư�� ������ �� ȣ��Ǵ� �Լ�, Vector3�� y�� * ��������, ���� ���ϴ� ����� Impulse �� ������ �����ϴ� �Լ�
    /// </summary>
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }

    /// <summary>
    /// �̵����� Ű�� �ԷµǾ��� �� ȣ��Ǵ� �κ�
    /// �̵����� Ű�� ��,��,��,�� �̱� ������ Vector2 ���·� ���� ��
    /// 
    /// 2D
    /// Vector2 �� x : �� ��
    /// Vector2 �� y : �� ��
    /// 
    /// 3D
    /// Vector3 �� x : �� ��
    /// Vector3 �� y : �� ��(������)
    /// Vector3 �� z : �� ��
    /// 
    /// Vector2,3�� x�� �� ��� ������ �����ͷ� �� �� ������
    ///             y�� �ٸ���! �̵��� ������ ������ �������(y �� ������ ���� �κп��� ����)
    /// </summary>
    /// <param name="value"></param>
    private void OnMove(InputValue value)
    {
        dir.x = value.Get<Vector2>().x;
        dir.z = value.Get<Vector2>().y;
    }

    /// <summary>
    /// ���� ��ư�� ���� ������ ȣ��Ǵ� �κ� 
    /// Jump �Լ��� ȣ���Ѵ�.
    /// </summary>
    private void OnJump()
    {
        Jump();
    }
}
