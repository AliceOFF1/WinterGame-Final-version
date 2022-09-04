using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFreazenBar : MonoBehaviour
{
    public static UIFreazenBar instance { get; private set; }
    public Image maskFreazen;
    float originalSize;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        originalSize = maskFreazen.rectTransform.rect.width;
    }

    public void SetValue(float value)
    {
        maskFreazen.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}

