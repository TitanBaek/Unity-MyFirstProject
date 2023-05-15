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
        rb.velocity = transform.forward * bulletSpeed; // 바라보고 있는 방향의 앞 방향, Vector3는 월드 기준이라 transform 을 기준으로 해주자 
        Destroy(gameObject, 5f);
    }
}
