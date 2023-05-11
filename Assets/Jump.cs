using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb = new Rigidbody(); 
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("1");
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }
}