using UnityEngine;
using System.Collections;

public class GameServer : MonoBehaviour {
    public static GameServer instance;

    public int startTurn;
    public int remainingTurn = 0;

    public Card[] cards;
    public bool[] tasks;

	void Start () {
        instance = this;

        tasks = new bool[cards.Length];
        int i = 0;
        foreach(var c in cards) {
            c.id = i++;
        }

        remainingTurn = 40; // TODO
        startTurn = remainingTurn;

	}

    public bool AllDone()
    {
        bool r = true;
        foreach(var t in tasks) r &= t;
        return r;
    }
}
