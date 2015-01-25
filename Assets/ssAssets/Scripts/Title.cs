using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {



	void Start () {
	
	}
	
	void Update () {
	
	}

    public void LetsPlay(int num) {
        GameServer.instance.player = num;

        GetComponent<NavButton>().Goto();
    }
}
