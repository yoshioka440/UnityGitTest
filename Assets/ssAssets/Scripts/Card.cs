using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
    public int id;

    public string name;
    public Sprite image;
    public string description;
    public int cost;

    public GameObject main, result;

    public bool disabled_variable = true;
    public bool disabled {
        set {
            disabled_variable = value;
            if (value)
            {
                GetComponent<UnityEngine.UI.Button>().interactable = true;
                GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 1);
            }
            else
            {
                GetComponent<UnityEngine.UI.Button>().interactable = false;
                GetComponent<UnityEngine.UI.Image>().color = new Color(1, 1, 1, 0.5f);
            }
            
        }
    }

    [System.Serializable]
    public class Links {
        public GameObject name;
        public GameObject image;
        public GameObject description;
    }
    public Links links;

	void Start () {
        name = base.name;
        if (name == "") Debug.LogError("Missing");
        if (image == null) Debug.LogWarning("Missing");
        if (description == "") Debug.LogWarning("Missing");

        links.name.GetComponent<UnityEngine.UI.Text>().text = name;
        links.image.GetComponent<UnityEngine.UI.Image>().sprite = image;
        links.description.GetComponent<UnityEngine.UI.Text>().text = cost + " : " + description;
	}
	
	void Update () {

	}

    public void OnClick() {
        Debug.Log(name + " Clicked");
        disabled = !disabled_variable;

        GameServer.instance.tasks[id] = true;
        GameServer.instance.remainingTurn -= cost;

        var nav = GetComponent<NavButton>();

        if (main == null) Debug.LogError("Invalid name");
        if (result == null) Debug.LogError("Invalid name");

        if (GameServer.instance.AllDone() || GameServer.instance.remainingTurn < 0) nav.Goto(result);
        else nav.Goto(main);

    }
}
