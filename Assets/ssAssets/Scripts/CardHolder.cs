using UnityEngine;
using System.Collections;

public class CardHolder : MonoBehaviour {

    public GameObject[] cards;

    private int h = 210, w = 160;

	void Awake () {
	    int i = 0;
        foreach(var c in cards) {

            RectTransform rt = c.GetComponent<RectTransform>();
            rt.anchoredPosition = new Vector2((i % 3 - 1) * w, - h - i / 3 * h);

            i++;
        }
        
        var r = GetComponent<UnityEngine.UI.ScrollRect>().content.sizeDelta;
        r.y = (2 + (i - 1) / 3) * h;
        GetComponent<UnityEngine.UI.ScrollRect>().content.sizeDelta = r;
        
	}
	
	void Update () {
	
	}
}
