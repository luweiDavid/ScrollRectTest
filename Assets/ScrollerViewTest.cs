using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollerViewTest : MonoBehaviour {

    public ScrollRect m_scrollRect;
    private RectTransform contentRectTr;

    private void Start()
    {
        if (m_scrollRect != null) {
            contentRectTr = m_scrollRect.transform.Find("Content").GetComponent<RectTransform>();

        }
    }

}
