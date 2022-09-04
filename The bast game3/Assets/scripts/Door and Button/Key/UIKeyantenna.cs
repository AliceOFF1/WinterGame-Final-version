using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyantenna : MonoBehaviour
{
    [SerializeField] private KeyantennaHolder keyantennabHolder;

    private Transform containerkeyantenna;
    private Transform keyantennaTemplate;

    private void Awake()
    {
        containerkeyantenna = transform.Find("containerkeyantenna");
        keyantennaTemplate = containerkeyantenna.Find("keyantennaTemplate");
        keyantennaTemplate.gameObject.SetActive(false);


    }

    private void Start()
    {
        keyantennabHolder.OnKeyantennasChanged += KeyantennaHolder_OnKeyantennasChanged;
    }

    private void KeyantennaHolder_OnKeyantennasChanged(object sender, System.EventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        // Clean up old keys 
        foreach (Transform child in containerkeyantenna)
        {
            if (child == keyantennaTemplate) continue;
            Destroy(child.gameObject);
        }

        // Instantiate current key list
        List<Keyantenna.KeyantennaType> keyantennaList = keyantennabHolder.GetKeyantennaList();
        for (int i = 0; i < keyantennaList.Count; i++)
        {
            Keyantenna.KeyantennaType keyantennaType = keyantennaList[i];
            Transform keyantennaTransform = Instantiate(keyantennaTemplate, containerkeyantenna);
            keyantennaTransform.gameObject.SetActive(true);
            keyantennaTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0);
            Image keyantennaImage = keyantennaTransform.Find("image").GetComponent<Image>();

        }
    }
}

