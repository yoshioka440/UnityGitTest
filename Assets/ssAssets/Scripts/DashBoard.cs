using UnityEngine;
using System.Collections;

public class DashBoard : MonoBehaviour {

    public GameObject Bar;
    public GameObject Parent;

    RectTransform BarRect;
    RectTransform ParentRect;

	void Start () {
        BarRect = Bar.GetComponent<RectTransform>();
        ParentRect = Parent.GetComponent<RectTransform>();
	}

    void Update()
    {
        var gs = GameServer.instance;
        var pos = ParentRect.anchoredPosition;
        pos.x = -(1 - (float)gs.remainingTurn / gs.startTurn) * BarRect.rect.width;
        ParentRect.anchoredPosition = pos;
    }

}
