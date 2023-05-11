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

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        // 질문입니다.
        // 아래와 같이 외부의 오브젝트의 값을 바꿔주는 작업은 Start에서 처리해주는게 올바른 방법인지 궁금합니다.


        // 외부의 객체(playerObject와 playerObject의 Rigidbody를 건드리는 작업이기 때문에 
        // Awake가 아닌 Start에서 처리해준다.
        playerObject.name = "ImPlayer";                         // 플레이어 오브젝트의 이름을 바꿔주는 부분
        rb = playerObject.GetComponent<Rigidbody>();            // rb에 참조된 playerObject의 Rigidbody를 참조
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // playerObject의 rb에 AddForce를 주어 게임이 시작되면 playerObject는 jumpForce강도로 점프한다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
