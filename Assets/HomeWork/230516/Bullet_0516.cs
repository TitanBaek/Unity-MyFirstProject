using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_0516 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private GameObject obj;
    [SerializeField] private float bulletSpeed;
    private AudioSource audioSource;
    [SerializeField] private AudioClip bullet_fire;
    [SerializeField] private AudioClip bullet_explo;
    private bool first_explo = true;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    } 

    private void Start()
    {
        rb.velocity = transform.forward * bulletSpeed;
        audioSource.clip = bullet_fire;
        SoundPlay();
    }

    private void SoundPlay()
    {
        Debug.Log(audioSource.clip.name);
        audioSource.Play();
    }

    private void SoundStop()
    {
        audioSource.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(obj, transform.position, transform.rotation);
        if (first_explo)
        {
            audioSource.clip = bullet_explo;
            SoundPlay();
            first_explo = false;
        }
        Destroy(gameObject,0.3f);
    }

    private void OnDestroy()
    {
        Debug.Log("디스트로이");
    }
}
