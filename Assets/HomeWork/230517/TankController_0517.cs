using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController_0517 : MonoBehaviour
{
    private Vector3 moveDir;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform fireStart_pos;
    [SerializeField] private Bullet_0517 bullet;
    [SerializeField] private CinemachineVirtualCamera normal_cam;
    [SerializeField] private CinemachineVirtualCamera aim_cam;
    private Animator ani;

    private AudioSource[] audioSources;
    private Coroutine coroutine;

    private void Awake()
    {
        audioSources = GetComponents<AudioSource>();
        ani = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            coroutine = StartCoroutine(RepeatFire());
        } else
        {
            StopCoroutine(coroutine);
        }
    }

    IEnumerator RepeatFire()
    {
        while (true)
        {
            ani.SetTrigger("ShotAnimation");
            audioSources[1].Play();
            Instantiate(bullet, fireStart_pos.position, fireStart_pos.rotation);
            yield return new WaitForSeconds(fireSpeed);
        }
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime);
    }

    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }

    private void OnAim(InputValue value)
    {
        if (value.isPressed)
        {
            aim_cam.Priority = 3;
            normal_cam.Priority = 1;
        } else
        {
            normal_cam.Priority = 3;
            aim_cam.Priority = 1;
        }
    }
}
