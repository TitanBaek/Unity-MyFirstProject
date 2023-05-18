using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TankShooter : MonoBehaviour
{
    public UnityEvent onFired;                                  // ����Ƽ �̺�Ʈ
    private Coroutine coroutine;                                // ���� �߻縦 ���� �ڷ�ƾ
    [SerializeField ] private BulletMover bullet;               // �߻�� ��ź�� ���� ������Ʈ(���⼱ BulletMover��� ������Ʈ ������ ������)
    [SerializeField] private Transform bulletStart;             // ��ź�� �߻�� ���ӿ�����Ʈ�� Transform!
    [SerializeField] private float repeatSpeed;                 // ���ӹ߻� �ӵ�(��)


    private void OnRepeatFire(InputValue value)                 // �����̽��ٰ� ���� ��� ȣ�� ��
    {
        if (value.isPressed)                                    // �ٿ� ������ �ִ�.
        {
            coroutine = StartCoroutine(OnFire());               // �ڷ�ƾ ����
        } else                                                  // �����̽��ٿ��� ���� ����
        {
            StopCoroutine(coroutine);                           // �ڷ�ƾ ����
        }
    }

    private IEnumerator OnFire()                                // ���� �߻� �ڷ�ƾ
    {
        while (true)
        {
            Fire();                                             // �߻� �Լ� ����
            yield return new WaitForSeconds(repeatSpeed);       // �߻� ������
        }
    }

    public void Fire()
    {
        Instantiate(bullet, bulletStart.position, bulletStart.rotation);            // ��ź�� ��ź���������� �����ǰ� ������ ����
        GameManager.Data.AddShootCount(1);                                          // DataManager(Model)�� AddShootCount�� 1�� �Բ� ȣ��
        onFired?.Invoke();                                                          // onFired �̺�Ʈ ����
    }



}
