using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountView : MonoBehaviour
{
    private TMP_Text textView;                              // ��ź �߻� ���� ��Ÿ���� Text

    private void Awake()                                    // ������Ʈ�� TEXT_PRO�� ��������
    {
        textView = GetComponent<TMP_Text>();
    }

    private void OnEnable()                                 // �� ������Ʈ�� Ȱ��ȭ �Ǹ� Model�� ����Ƽ �̺�Ʈ(�Ǵ� Action)�� SetCountUI�� �־������.
    {
        GameManager.Data.OnChangedCount += SetCountUI;
    }

    private void OnDisable()
    {
        GameManager.Data.OnChangedCount -= SetCountUI;      // �� ������Ʈ�� ��Ȱ��ȭ �Ǹ� Model�� ����Ƽ �̺�Ʈ(�Ǵ� Action)�� SetCountUI�� ��������.
    }
    private void SetCountUI(int count)
    {
        textView.text = count.ToString();                   // Text�� ���� count(Model�� shootCount)�� �����Ѵ�.
    }
}
