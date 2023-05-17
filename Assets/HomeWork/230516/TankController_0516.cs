using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class TankController_0516 : MonoBehaviour
{
    private Vector3 moveDir;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Bullet_0516 bullet;
    [SerializeField] private Transform bulletStart_pos;
    [SerializeField] private AudioSource bullet_AudioSource;
    //[SerializeField] private AudioClip bullet_Audioclip;
    [SerializeField] private CinemachineVirtualCamera normalView;
    [SerializeField] private CinemachineVirtualCamera aimView;

    private Animator animator;
    //private bool nowAim = false;

    private Coroutine coroutine;
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        bullet_AudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
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

    public void Fire()
    {
        animator.SetTrigger("Fire");
        Instantiate(bullet, bulletStart_pos.position, bulletStart_pos.rotation);
    }

    IEnumerator RepeatFire()
    {
        while (true)
        {
            animator.SetTrigger("Fire");
            Instantiate(bullet,bulletStart_pos.position, bulletStart_pos.rotation);

            yield return new WaitForSeconds(1f);
        }
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

    private void OnAim(InputValue value)
    {
        if(value.isPressed)
        {
            //nowAim = true;
            aimView.Priority = 3;
        } else
        {
            //nowAim = false;
            aimView.Priority = 1;

        }
    }
}
