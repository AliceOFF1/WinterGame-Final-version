using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITrambHolder : MonoBehaviour
{
    [SerializeField] private TrambHolder trambHolder;

    private Transform containertramb;
    private Transform trambTemplate;

    private void Awake()
    {
        containertramb = transform.Find("containertramb");
        trambTemplate = containertramb.Find("trambTemplate");
        trambTemplate.gameObject.SetActive(false);


    }

    private void Start()
    {
        trambHolder.OnTrambsChanged += TrambHolder_OnTrambsChanged;
    }

    private void TrambHolder_OnTrambsChanged(object sender, System.EventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        // Clean up old keys 
        foreach (Transform child in containertramb)
        {
            if (child == trambTemplate) continue;
            Destroy(child.gameObject);
        }

        // Instantiate current key list
        List<Tramb.TrambType> trambList = trambHolder.GetTrambList();
        for (int i = 0; i < trambList.Count; i++)
        {
            Tramb.TrambType trambType = trambList[i];
            Transform trambTransform = Instantiate(trambTemplate, containertramb);
            trambTransform.gameObject.SetActive(true);
            trambTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0);
            Image trambImage = trambTransform.Find("image").GetComponent<Image>();

        }
    }
}
