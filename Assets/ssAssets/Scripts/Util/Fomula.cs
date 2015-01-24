using UnityEngine;
using System.Collections;

public class Fomula : MonoBehaviour {

    public static System.Func<float, float> EaseIn = (t) => (1 - Mathf.Pow(1 - t, 2));

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
