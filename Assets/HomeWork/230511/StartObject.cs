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

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        // �����Դϴ�.
        // �Ʒ��� ���� �ܺ��� ������Ʈ�� ���� �ٲ��ִ� �۾��� Start���� ó�����ִ°� �ùٸ� ������� �ñ��մϴ�.


        // �ܺ��� ��ü(playerObject�� playerObject�� Rigidbody�� �ǵ帮�� �۾��̱� ������ 
        // Awake�� �ƴ� Start���� ó�����ش�.
        playerObject.name = "ImPlayer";                         // �÷��̾� ������Ʈ�� �̸��� �ٲ��ִ� �κ�
        rb = playerObject.GetComponent<Rigidbody>();            // rb�� ������ playerObject�� Rigidbody�� ����
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // playerObject�� rb�� AddForce�� �־� ������ ���۵Ǹ� playerObject�� jumpForce������ �����Ѵ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
