using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class BallMove : MonoBehaviour
{
    private Rigidbody rb;           // Addforce 로 움직임을 줄 리지드 바디 
    private Vector3 dir;            // 키 입력에 따라 값을 매겨줄 x,y,z 를 담을 Vector3

    /// <summary>
    /// 이동하는 힘과 점프하는 힘 
    /// </summary>
    [SerializeField]
    private float movePower = 1f;
    [SerializeField]
    private float jumpPower = 1f; 

    /// <summary>
    /// 게임 실행 시 리지드바디 컴포넌트 가져오기
    /// </summary>
    private void Awake()
    {
       rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 내  프레임마다 캐릭터 움직임 여부 파악하여 이동 함수 호출
    /// </summary>
    private void Update()
    {
        Move();
    }
    
    /// <summary>
    /// InputSystem 에서 키 입력에 따라 값을 정의한 Vector3 dir * 이동세기로 rb에 힘을 가해 공의 이동을 구현함
    /// </summary>
    private void Move()
    {
        rb.AddForce(dir * movePower);
    }

    /// <summary>
    /// 점프버튼이 눌렸을 시 호출되는 함수, Vector3의 y축 * 점프세기, 힘을 가하는 방식을 Impulse 로 점프를 구현하는 함수
    /// </summary>
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }

    /// <summary>
    /// 이동관련 키가 입력되었을 때 호출되는 부분
    /// 이동관련 키는 상,하,좌,우 이기 떄문에 Vector2 형태로 저장 됨
    /// 
    /// 2D
    /// Vector2 의 x : 좌 우
    /// Vector2 의 y : 상 하
    /// 
    /// 3D
    /// Vector3 의 x : 좌 우
    /// Vector3 의 y : 상 하(높낮이)
    /// Vector3 의 z : 앞 뒤
    /// 
    /// Vector2,3의 x는 좌 우로 동일한 데이터로 볼 수 있지만
    ///             y는 다르다! 이동시 높낮이 변동이 없어야함(y 값 변동은 점프 부분에서 구현)
    /// </summary>
    /// <param name="value"></param>
    private void OnMove(InputValue value)
    {
        dir.x = value.Get<Vector2>().x;
        dir.z = value.Get<Vector2>().y;
    }

    /// <summary>
    /// 점프 버튼이 눌릴 때마다 호출되는 부분 
    /// Jump 함수를 호출한다.
    /// </summary>
    private void OnJump()
    {
        Jump();
    }
}
