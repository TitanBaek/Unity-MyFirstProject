using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_0517 : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject explo_ani;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explo_ani,transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
