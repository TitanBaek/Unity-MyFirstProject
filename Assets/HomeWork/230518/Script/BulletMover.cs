using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;                     // ��ź�� �ӵ�
    [SerializeField] private GameObject explosion;                  // ��ź�� ������ �ִϸ��̼�(?)�� ���� ���� ������Ʈ
    Rigidbody rb;                                                   // ��ź �̵�(?)�� ���� ������ٵ�
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                             // rb�� �� ���� ������Ʈ�� ������ٵ� ������Ʈ�� ã�� �־���
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;              // ���ӿ�����Ʈ�� �����Ǹ� velocity���� ��ź�� �̵���Ŵ( ���ӵ� ���� ������ �̵� )
    }

    private void OnCollisionEnter(Collision collision)                          // �浹 �ߴ�!
    {
        Instantiate(explosion,transform.position,transform.rotation);           // �浹 ��ġ�� ��ź�� ������ �ִϸ��̼��� ���� ���� ������Ʈ ����
        Destroy(gameObject);                                                    // �� ���ӿ�����Ʈ Destroy
    }

}
