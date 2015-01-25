using UnityEngine;
using System.Collections;

public class GameServer : MonoBehaviour {
    public static GameServer instance;

    public int player;

    public int startTurn;
    public int remainingTurn = 0;
    public int lastCall;
    public int callCount = 3;

    public Card[] cards;
    public bool[] tasks;

    void Start()
    {
        /*
        GameObject.Find("Title").SetActive(true);
        GameObject[] screens = GameObject.FindGameObjectsWithTag("screen");
        foreach (var s in screens)
        {
            s.SetActive(false);
        }*/
    }

	void OnEnable () {
        instance = this;

        int i = 0;
        foreach(var c in cards) {
            c.id = i++;
        }

        ResetThem();

	}

    public void ResetThem()
    {
        tasks = new bool[cards.Length];
        remainingTurn = 40; // TODO
        startTurn = remainingTurn;
        lastCall = remainingTurn;
    }

    public bool AllDone()
    {
        bool r = true;
        foreach(var t in tasks) r &= t;
        return r;
    }

    public bool CouldCall()
    {
        return remainingTurn < lastCall - 5; //wait 5turn till next
    }

    public void Call(int type)
    {
        callCount--;
        remainingTurn += (int)(Random.value * (2 + type));
        lastCall = remainingTurn;
    }
}
