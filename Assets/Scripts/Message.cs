using UnityEngine;
using System.Collections;

public class Message : MonoBehaviour {

	public GameObject parentObj;
	public GameObject message_eazy;
	public GameObject message_medium;
	public GameObject message_hard;
	
	public GameObject message_milk1;
	public GameObject message_milk2;
	public GameObject message_pizza1;
	public GameObject message_pizza2;
	public GameObject message_Drugstore1;
	public GameObject message_Drugstore2;
	
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void AppearMessage() {
		Instantiate(message_eazy);
		message_eazy.transform.parent = parentObj.transform;
	}
}
