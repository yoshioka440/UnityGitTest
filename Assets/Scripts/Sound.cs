using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//SoundManager.Instance.PlaySE(1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//SoundManager.Instance.PlaySE(1);
		if (Input.GetMouseButtonDown (1)) {
			PlaySE();
		}
	}
	
	public void PlaySE() {
		SoundManager.Instance.PlaySE(1);
		
	}
}
