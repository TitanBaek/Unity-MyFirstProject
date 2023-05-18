using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountView : MonoBehaviour
{
    private TMP_Text textView;                              // 포탄 발사 수를 나타내는 Text

    private void Awake()                                    // 컴포넌트의 TEXT_PRO를 가져오고
    {
        textView = GetComponent<TMP_Text>();
    }

    private void OnEnable()                                 // 현 컴포넌트가 활성화 되면 Model의 유니티 이벤트(또는 Action)에 SetCountUI를 넣어버린다.
    {
        GameManager.Data.OnChangedCount += SetCountUI;
    }

    private void OnDisable()
    {
        GameManager.Data.OnChangedCount -= SetCountUI;      // 현 컴포넌트가 비활성화 되면 Model의 유니티 이벤트(또는 Action)에 SetCountUI를 빼버린다.
    }
    private void SetCountUI(int count)
    {
        textView.text = count.ToString();                   // Text의 값을 count(Model의 shootCount)로 지정한다.
    }
}
