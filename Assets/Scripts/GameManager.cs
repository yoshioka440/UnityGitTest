using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	enum State : int {Dice=1, ShowPlace, ChoosePlace, Task, Item, Finish};
	private int state;
	private int diceNum;
	public int defaulDicetNum = 1;
	private bool diceRolled;
	
	public static bool canRollDice;
	Dice dice;
		
	// Use this for initialization
	void Start () {
		state = (int)State.Dice;
		diceNum = defaulDicetNum;
		diceRolled = false;
		Debug.Log ("state: " + state);
		canRollDice = true;
		dice = GameObject.Find("Dice").GetComponent<Dice>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		switch (state) {
		case 1:
			//Debug.Log ("state: " + state);
			//diceRolled = true;
			
			if (dice.Rooled) {
				canRollDice = false;
				diceNum = dice.DiceNum;
				state++;
			}
			break;
			
		case 2:
			Debug.Log ("state: " + state);
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			canRollDice = true;
			break;
		default :
			break;
		}
	}
}
