using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController_230515 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;                   // ��ũ�� �̵��ӵ� ( transform )
    [SerializeField] private float rotateSpeed;                 // ��ũ�� ȸ���ӵ� ( transform )
    private Vector3 moveDir;                                    // Ű �Է¿� ���� ��ġ/���� ���� ���� ���� Vector3

    [SerializeField] private Bullet_230515 bulletPrefab;        // �Ѿ� Prefab
    [SerializeField] private Transform bulletStart_pos;         // �Ѿ��� �߻� �� ���� ������Ʈ�� Transform
    [SerializeField] private float fireSpeed;                   // ��ź �߻簣 ������(�ڷ�ƾ�� �� ��)

    private Coroutine bulletCoroutine;                          // ��ź ���� �߻縦 �����ϱ� ���� �ڷ�ƾ�� ���� �ڷ�ƾ �ڷ����� ����

    IEnumerator RepeatFire()                                    // ���� �߻� �ڷ�ƾ 
    {
        while (true)                                                                                // ����ؼ� �ݺ�
        {
            Instantiate(bulletPrefab, bulletStart_pos.position, bulletStart_pos.rotation);          // ��ź Prefab�� ���� ��ġ�� ������ �Ű������� �Ͽ� ������ �ν��Ͻ� ����
            yield return new WaitForSeconds(fireSpeed);                                             // fireSpeed ��ŭ �������� ��

        }
    }
    private void Update()                                                                           // �����Ӵ����� �̵��� ȸ�� �Լ� ȣ��
    {
        Move();
        Rotate();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime, Space.Self);  // ��ũ �̵� ����
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.Self);        // ��ũ ȸ�� ���� 
    }
    
    void OnMove(InputValue value)                                                                  // �̵� Key �Է��� �Ǿ��� �� ȣ��Ǵ� �޼ҵ�
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }

    void OnRepeatFire(InputValue value)                                                            // ���� ��ư(���콺 ����)�� �Է� �Ǿ��� �� ȣ��Ǵ� �޼ҵ�
    {
        if (value.isPressed)                                                                       // .isPressed �� ���� ������ �ִ� ���¸� ����
        {
            bulletCoroutine = StartCoroutine(RepeatFire());
        } else                                                                                     // ��ư�� ���ȴٰ� �������� ��
        {
            StopCoroutine(bulletCoroutine);
        }
    }

    void OnFire(InputValue value)                                                                   // �Ϲ� �߻�(Space)�� ������ �� ȣ��Ǵ� �޼ҵ� 
    {
        Instantiate(bulletPrefab, bulletStart_pos.position, bulletStart_pos.rotation);
    }
}
