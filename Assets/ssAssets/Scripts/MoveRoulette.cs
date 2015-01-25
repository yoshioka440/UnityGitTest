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
        if(!decided) text.GetComponent<UnityEngine.UI.Text>().text = "" + (int)(Random.value * 3 + 1);
	}

    public void OnClick()
    {
        decided = true;
        StartCoroutine(Roulette());
    }

    IEnumerator Roulette()
    {
        var ev = GameObject.Find("EventSystem").GetComponent<UnityEngine.EventSystems.EventSystem>();
        ev.enabled = false;
        var value = (int)(Random.value * 3 + 1);
        text.GetComponent<UnityEngine.UI.Text>().text = "" + value;

        yield return new WaitForSeconds(2);
        GameServer.instance.remainingTurn -= 1;

        var nav = roulette.GetComponent<NavButton>();

        if (main == null) Debug.LogError("Invalid name");
        if (result == null) Debug.LogError("Invalid name");

        if (GameServer.instance.AllDone() || GameServer.instance.remainingTurn < 0) nav.Goto(result);
        else nav.Goto(main);

        yield return null;
    }
}
