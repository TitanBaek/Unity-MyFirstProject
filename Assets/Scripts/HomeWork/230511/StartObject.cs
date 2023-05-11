using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartObject : MonoBehaviour
{
    private Rigidbody rb;                   // RigidBody 선언
    [Header("Change MainTank name")]        // 인스펙터의 플레이어 오브젝트 참조 부분 네이밍
    public GameObject playerObject;         // 플레이어 오브젝트 
    [SerializeField]                        // 직렬화
    [Header("Set JumpForce")]               // 인스펙터의 점프 강도 부분 네이밍
    private float jumpForce = 5f;           // 점프 강도


    // Start is called before the first frame update
    void Start()
    {
        playerObject.name = "ImPlayer";                         // 플레이어 오브젝트의 이름을 바꿔주는 부분 그렇기 때문에 Awake에 안쓰고 Start에 써주었다.
        rb = playerObject.GetComponent<Rigidbody>();            // rb에 참조된 playerObject의 Rigidbody를 참조
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // playerObject의 rb에 AddForce를 주어 게임이 시작되면 playerObject는 jumpForce강도로 점프한다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
