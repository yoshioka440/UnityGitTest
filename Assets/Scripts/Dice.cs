using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour {

	private GameObject go;
	private bool flg;
	
	private int diceNum;
	private bool rolled;
	private bool pushDiceImage;
	
	public int DiceNum {
		//set{this.diceNum = value;}
		get{return this.diceNum;}
	}
	
	public bool Rooled {
		//set{this.rolled = value;}
		get{return rolled;}
	}
	
	// Use this for initialization
	void Start () {
	
		go = GameObject.Find("Dice");
		flg = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		TouchAction();
		if (GameManager.canRollDice && !flg) {
			diceNum = RollDice();
			rolled = true;
		}
		
	}
	
	private int RollDice() {
		// 保留
		//Random rand = new Random();
		//return rand.Next(1, 3);
		
		return 1;
	}
	
	private void TouchAction ()
	{
		// Input.GetMouseButtonDown(0)でマウスクリック取得
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("LeftClick!");
			Ray ray = new Ray();
			RaycastHit hit = new RaycastHit();
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			//マウスクリックした場所からRay？を飛ばし、オブジェクトがあればtrue 
			if(Physics.Raycast(ray.origin,ray.direction,out hit,Mathf.Infinity)){
				Debug.Log(hit.collider.gameObject.name);
				
				Color color = new Color(Random.value, Random.value, Random.value, 0.1f);
				hit.collider.renderer.material.color = color;
				 
				go.gameObject.SetActive(flg);
				flg = !flg;
				
			}
			
		}
	}
}
