using UnityEngine;
using System.Collections;

public class DashBoard : MonoBehaviour {

    public GameObject Bar;
    public GameObject Parent;
    public GameObject text;

    RectTransform BarRect;
    RectTransform ParentRect;

	void OnEnable () {
        BarRect = Bar.GetComponent<RectTransform>();
        ParentRect = Parent.GetComponent<RectTransform>();
	}

    void Update()
    {
        var gs = GameServer.instance;
        var pos = ParentRect.anchoredPosition;
        pos.x = -(1 - (float)gs.remainingTurn / gs.startTurn) * BarRect.rect.width;
        ParentRect.anchoredPosition = pos;


        text.GetComponent<UnityEngine.UI.Text>().text = " " + gs.remainingTurn + " turn\n to death";
    }

}
