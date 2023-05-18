using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;                     // 포탄의 속도
    [SerializeField] private GameObject explosion;                  // 포탄이 터지는 애니메이션(?)을 담은 게임 오브젝트
    Rigidbody rb;                                                   // 포탄 이동(?)을 위한 리지드바디
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();                             // rb에 현 게임 오브젝트의 리지드바디 컴포넌트를 찾아 넣어줌
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;              // 게임오브젝트가 생성되면 velocity으로 포탄을 이동시킴( 가속도 없는 힘으로 이동 )
    }

    private void OnCollisionEnter(Collision collision)                          // 충돌 했다!
    {
        Instantiate(explosion,transform.position,transform.rotation);           // 충돌 위치에 포탄이 터지는 애니메이션을 담은 게임 오브젝트 생성
        Destroy(gameObject);                                                    // 현 게임오브젝트 Destroy
    }

}
