using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float Speed = 10f;
    float h, v;
    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        // Point 1.
        h = Input.GetAxis("Horizontal");        // ������ Ű �Է�
        v = Input.GetAxis("Vertical");          // ������ Ű �Է�
        Vector3 dir = new Vector3(h, 0, v);

        // Point 2.
        // transform.position += dir * Speed * Time.deltaTime;
        if (!(h == 0 && v == 0))
        {
            // �̵��� ȸ���� �Բ� ó��
            transform.position += dir * Speed * Time.deltaTime;
            // ȸ���ϴ� �κ�. Point 1.
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * Speed);
        }
    }
}

