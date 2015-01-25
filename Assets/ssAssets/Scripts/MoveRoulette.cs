using UnityEngine;
using System.Collections;

public class MoveRoulette : MonoBehaviour {
    public GameObject text;
    public GameObject roulette;

    bool decided;

    public GameObject main, result;

	void OnEnable () {
        decided = false;
	}
	
	void Update () {
        if (!decided)
        {
            ;
            text.GetComponent<UnityEngine.UI.Text>().text = "";

            for (int i = 0; i < GameServer.instance.player; i++)
            {
                var value = (int)(Random.value * 3 + 1);
                text.GetComponent<UnityEngine.UI.Text>().text += " " + value;
            }
        }
	}

    public void OnClick()
    {
        if (!decided)
        {
            decided = true;
            
            text.GetComponent<UnityEngine.UI.Text>().text = "";

            for (int i = 0; i < GameServer.instance.player; i++)
            {
                var value = (int)(Random.value * 3 + 1);
                text.GetComponent<UnityEngine.UI.Text>().text += " " + value;
            }
            GameServer.instance.remainingTurn -= 1;
        }
        else
        {
            var nav = roulette.GetComponent<NavButton>();

            if (main == null) Debug.LogError("Invalid name");
            if (result == null) Debug.LogError("Invalid name");

            if (GameServer.instance.AllDone() || GameServer.instance.remainingTurn < 0) nav.Goto(result);
            else nav.Goto(main);
        }
    }
}
