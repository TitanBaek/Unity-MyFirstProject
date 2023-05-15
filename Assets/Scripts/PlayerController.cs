using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDir;

    [SerializeField]
    private float rotateSpeed = 1f;
    [SerializeField]
    private float moveSpeed = 1f;
    [SerializeField]
    private float jumpPower = 1f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();             // 현재 이 스크립트가 붙은 오브젝트에서 Rigidbody 컴포넌트를 찾는다.
    }
    private void Update()
    {
        Move();
        Rotate();
        //LookAt();
    }
    private void Move()
    {
        //transform.position += moveDir * moveSpeed * Time.deltaTime;         // 1 프레임당 걸리는 시간을 곱해줘야 속력으로 움직일 수 있다. 단순 증감이 아닌 입력시간을 곱해줘야함
        //rb.AddForce(moveDir * movePower);

        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.Self);

    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World);
    }

    // <Quarternion & Euler>
    // Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
    //				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
    // EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
    //				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
    // 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 
    private void Rotation()
    {
        /*
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0,0 );
        Vector3 rotation = transform.rotation.ToEulerAngles();
        */

        //Vector3 rotation = transform.rotation.ToEulerAngles();
        //transform.rotation = Quaternion.Euler(rotation);
    }
    private void LookAt()
    {
        transform.LookAt(new Vector3(0,0,0));                               // 특정 목표를 바라봐라
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }

    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }

}
