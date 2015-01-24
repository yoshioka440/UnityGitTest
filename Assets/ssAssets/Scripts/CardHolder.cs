using UnityEngine;
using System.Collections;

public class CardHolder : MonoBehaviour {

    public GameObject[] cards;

    private int h = 110, w = 60 + 100;

	void Start () {
	    int i = 0;
        foreach(var c in cards) {
            int hh = h;
            if (i % 2 == 0) hh = -hh;

            RectTransform rt = c.GetComponent<RectTransform>();
            rt.anchoredPosition = new Vector2(60 + i / 2 * w, hh);

            i++;
        }
        
        var r = GetComponent<UnityEngine.UI.ScrollRect>().content.sizeDelta;
        r.x = 120 + (i - 1) / 2 * w;
        GetComponent<UnityEngine.UI.ScrollRect>().content.sizeDelta = r;
        
	}
	
	void Update () {
	
	}

    public void addCard() { 
    }

}
