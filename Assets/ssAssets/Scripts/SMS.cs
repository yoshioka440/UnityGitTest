using UnityEngine;
using System.Collections;

public class SMS : MonoBehaviour {

    public GameObject msgs;

	void Start () {
	
	}
	
	void Update () {
        if (GameServer.instance.CouldCall()) msgs.SetActive(true);
        else msgs.SetActive(false);
            
	}
}
