using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet_230515 : MonoBehaviour
{
    private Rigidbody rb;                                               // ������ٵ�
    [SerializeField] private float bulletSpeed;                         // ��ź�� �߻� ���ǵ�
    [SerializeField] private GameObject explosionEffect;
     
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                                 // ������ ����ʰ� ���ÿ� ������ٵ� ������Ʈ�� ������ �ʱ�ȭ �Ѵ�.
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;                  // ��ź�� �����Ǹ� �� ��ź�� �������� �߻� ���ǵ常ŭ ���� ���� �������� �ش�(?)
        Destroy(gameObject,5f);                                         // 5�� �� ��ź ����
    }

    private void OnCollisionEnter()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}
