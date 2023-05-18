using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TankShooter : MonoBehaviour
{
    public UnityEvent onFired;
    private Coroutine coroutine;
    [SerializeField ] private BulletMover bullet;
    [SerializeField] private Transform bulletStart;
    [SerializeField] private float repeatSpeed;
    
    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            coroutine = StartCoroutine(OnFire());
        } else
        {
            StopCoroutine(coroutine);
        }
    }

    private IEnumerator OnFire()
    {
        while (true)
        {
            Fire();
            yield return new WaitForSeconds(repeatSpeed);
        }
    }

    private void Fire()
    {
        Instantiate(bullet, bulletStart.position, bulletStart.rotation);
        onFired?.Invoke();
    }

}
