using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_0516 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private GameObject obj;
    [SerializeField] private float bulletSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = Vector3.forward * bulletSpeed;
    }
}
