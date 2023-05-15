    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityGameObject : MonoBehaviour
{

    /************************************************************************
	 * ���ӿ�����Ʈ (GameObject)
	 * 
	 * ���� �����ϴ� ��� ������Ʈ�� �⺻ Ŭ����
	 * ���ӿ�����Ʈ�����δ� �������� ����� ����. �������� ����� ������Ʈ���� ����
	 * ���ӿ�����Ʈ�� ������Ʈ���� ������ ���� �����̳�
	 ************************************************************************/

    GameObject gameObj;

    // <���ӿ�����Ʈ �������>
    // name			: ���ӿ�����Ʈ�� �̸�
    // active		: ���ӿ�����Ʈ�� Ȱ��ȭ ����, ��Ȱ��ȭ�� ��� ���� ���� ���ӿ�����Ʈ�� ��޵�
    // static		: ���ӿ�����Ʈ�� �������� ����, ��Ÿ�� ��� ������� �ʴ� �����͸� �����Ͽ� ����ȭ
    // tag			: ���ӿ�����Ʈ�� �±�, ���ӿ�����Ʈ�� Ư���ϱ� ���� �������� ���
    // layer		: ���ӿ�����Ʈ�� ���̾�, ������ ���ӿ�����Ʈ�� �и��ϴ� ���� (ī�޶��� ������ ǥ��, �浹 �׷�, ���̾� ����ũ � ���)
    // component	: ���ӿ�����Ʈ�� ���Ե� ��ɸ��, ���ӿ�����Ʈ�� ������Ʈ�� ������� �����̳� ����

    /************************************************************************
	 * ������Ʈ (Component)
	 * 
	 * Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
	 * ���ӿ�����Ʈ�� �۵��� ������ ��ǰ
	 * ���ӿ�����Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ
	 ************************************************************************/

    /************************************************************************
	 * MonoBehaviour
	 * 
	 * ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
	 * ���� ������Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
	 * ��ũ��Ʈ ����ȭ ���, ����Ƽ�޽��� �̺�Ʈ�� �޴� ���, �ڷ�ƾ ����� ������
	 ***********************************************************************/

    // <��ũ��Ʈ ����ȭ ���>
    // �ν����� â���� ������Ʈ�� �ɹ����� ���� Ȯ���ϰų� �����ϴ� ���
    // ������Ʈ�� ������ �����͸� Ȯ���ϰų� ����
    // ������Ʈ�� �������� �����͸� �巡�� �� ��� ������� ����

    // <�ν�����â ����ȭ�� ������ �ڷ���>
    [Header("C# Type")]
    public bool boolValue;
    public int intValue;
    public float floatValue;
    public string stringValue;
    // �� �� �⺻ �ڷ���

    // �⺻ �ڷ����� �����ڷᱸ��
    public int[] array;
    public List<int> list;

    [Header("Unity Type")]
    public Vector3 vector3;
    public Color color;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;

    [Header("Unity GameObject")]
    public GameObject obj;

    [Header("Unity Component")]
    public new Transform transform;
    public new Rigidbody rigidbody;
    public new Collider collider;

    [Header("Unity Event")]
    public UnityEvent OnEvent;

    // <��Ʈ����Ʈ>
    // Ŭ����, ������Ƽ �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

    [Space(30)]

    [Header("Unity Attribute")]
    [SerializeField]
    private int privateValue;
    [HideInInspector]
    public int publicValue;

    [Range(0, 10)]
    public float rangeValue;

    [TextArea(3, 5)]
    public string textField; 
}
