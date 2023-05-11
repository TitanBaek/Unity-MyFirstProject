using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartObject : MonoBehaviour
{
    private Rigidbody rb;                   // RigidBody ����
    [Header("Change MainTank name")]        // �ν������� �÷��̾� ������Ʈ ���� �κ� ���̹�
    public GameObject playerObject;         // �÷��̾� ������Ʈ 
    [SerializeField]                        // ����ȭ
    [Header("Set JumpForce")]               // �ν������� ���� ���� �κ� ���̹�
    private float jumpForce = 5f;           // ���� ����


    // Start is called before the first frame update
    void Start()
    {
        playerObject.name = "ImPlayer";                         // �÷��̾� ������Ʈ�� �̸��� �ٲ��ִ� �κ� �׷��� ������ Awake�� �Ⱦ��� Start�� ���־���.
        rb = playerObject.GetComponent<Rigidbody>();            // rb�� ������ playerObject�� Rigidbody�� ����
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // playerObject�� rb�� AddForce�� �־� ������ ���۵Ǹ� playerObject�� jumpForce������ �����Ѵ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
