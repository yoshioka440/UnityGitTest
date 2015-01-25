using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

    public GameObject text;
    public GameObject back;

	void OnEnable () {
        if (GameServer.instance.remainingTurn < 0) text.GetComponent<UnityEngine.UI.Text>().text = "You are dead!";
        else text.GetComponent<UnityEngine.UI.Text>().text = "You left " + GameServer.instance.remainingTurn + " turns!\n" +
            "and " + GameServer.instance.callCount + " calls!";
	}

    public void OnBack()
    {
        GameServer.instance.ResetThem();
        back.GetComponent<NavButton>().Goto();
    }
}
