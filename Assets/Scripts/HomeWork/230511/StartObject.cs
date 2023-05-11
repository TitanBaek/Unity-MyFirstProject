using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartObject : MonoBehaviour
{
    private Rigidbody rb;
    [Header("Change MainTank name")]
    public GameObject playerObejct;
    [Header("Set JumpForce")]
    public float jumpForce;

    private void Awake()
    {
        playerObejct.name = "ImPlayer";
        rb = playerObejct.GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
