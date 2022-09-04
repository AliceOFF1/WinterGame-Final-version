using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEatBar : MonoBehaviour
{
    public static UIEatBar instance { get; private set; }
    public Image maskEat;
    float originalSize;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        originalSize = maskEat.rectTransform.rect.width;
    }

    public void SetValue(float value)
    {
        maskEat.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}