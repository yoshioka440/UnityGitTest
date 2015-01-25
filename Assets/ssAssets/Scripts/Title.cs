using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {


    public GameObject[] actives;
    public GameObject[] cards;

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void LetsPlay(int num) {
        GameServer.instance.player = num;

        foreach (var a in actives) a.SetActive(true);
        foreach (var a in cards) a.GetComponent<Card>().disabled = true;

        GetComponent<NavButton>().Goto();
    }
}
