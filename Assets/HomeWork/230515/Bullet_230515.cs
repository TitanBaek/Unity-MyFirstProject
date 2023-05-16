using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet_230515 : MonoBehaviour
{
    private Rigidbody rb;                                               // 리지드바디
    [SerializeField] private float bulletSpeed;                         // 포탄의 발사 스피드
    [SerializeField] private GameObject explosionEffect;
     
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                                 // 게임이 실행됨과 동시에 리지드바디 컴포넌트를 가져와 초기화 한다.
    }
    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;                  // 포탄이 생성되면 현 포탄을 기준으로 발사 스피드만큼 힘을 가해 움직임을 준다(?)
        Destroy(gameObject,5f);                                         // 5초 뒤 포탄 삭제
    }

    private void OnCollisionEnter()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
}
