using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

    public GameObject text;
    public GameObject back;

	void OnEnable () {
        text.GetComponent<UnityEngine.UI.Text>().text = "You left " + GameServer.instance.remainingTurn + " turns!";
	}

    public void OnBack()
    {
        GameServer.instance.ResetThem();
        back.GetComponent<NavButton>().Goto();
    }
}
