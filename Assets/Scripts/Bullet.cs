using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour{
    [SerializeField]
    private float bulletSpeed; 

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed; // �ٶ󺸰� �ִ� ������ �� ����, Vector3�� ���� �����̶� transform �� �������� ������ 
        Destroy(gameObject, 5f);
    }
}
