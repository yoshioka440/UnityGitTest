using UnityEngine;
using System.Collections;

public class MoveRoulette : MonoBehaviour {
    public GameObject text;

    bool decided;

    public GameObject main, result;

	void Start () {
        text = GameObject.Find("Text");
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
        GameServer.instance.remainingTurn -= value;

        var nav = GetComponent<NavButton>();

        if (main == null) Debug.LogError("Invalid name");
        if (result == null) Debug.LogError("Invalid name");

        if (GameServer.instance.AllDone()) nav.Goto(result);
        else nav.Goto(main);

        yield return null;
    }
}
