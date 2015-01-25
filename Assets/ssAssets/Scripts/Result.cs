using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

    public GameObject text;
    public GameObject back;

	void OnEnable () {
        if (GameServer.instance.remainingTurn < 0) text.GetComponent<UnityEngine.UI.Text>().text = "You are dead!";
        else text.GetComponent<UnityEngine.UI.Text>().text = "You finished with\n " + GameServer.instance.remainingTurn + " turn " +
            "and\n " + GameServer.instance.callCount + " calls left!";
	}

    public void OnBack()
    {
        GameServer.instance.ResetThem();
        back.GetComponent<NavButton>().Goto();
    }
}
