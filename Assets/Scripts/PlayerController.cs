using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDir;

    [SerializeField]
    private float rotateSpeed = 1f;
    [SerializeField]
    private float moveSpeed = 1f;
    [SerializeField]
    private float jumpPower = 1f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();             // ���� �� ��ũ��Ʈ�� ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�´�.
    }
    private void Update()
    {
        Move();
        Rotate();
        //LookAt();
    }
    private void Move()
    {
        //transform.position += moveDir * moveSpeed * Time.deltaTime;         // 1 �����Ӵ� �ɸ��� �ð��� ������� �ӷ����� ������ �� �ִ�. �ܼ� ������ �ƴ� �Է½ð��� ���������
        //rb.AddForce(moveDir * movePower);

        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self);

    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World);
    }

    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� 
    private void Rotation()
    {
        /*
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0,0 );
        Vector3 rotation = transform.rotation.ToEulerAngles();
        */

        //Vector3 rotation = transform.rotation.ToEulerAngles();
        //transform.rotation = Quaternion.Euler(rotation);
    }
    private void LookAt()
    {
        transform.LookAt(new Vector3(0,0,0));                               // Ư�� ��ǥ�� �ٶ����
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }

    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }

}
