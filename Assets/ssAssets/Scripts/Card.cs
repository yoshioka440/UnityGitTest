using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    public string name;
    public Sprite image;
    public string description;

    public bool disabled_variable = true;
    public bool disabled {
        set {
            disabled_variable = value;
            if (value)
            {
                //   GetComponent<UnityEngine.UI.Button>().interactable = true;
                GetComponent<CanvasRenderer>().SetAlpha(1f);
                
            }
            else
            {
                //  GetComponent<UnityEngine.UI.Button>().interactable = false;
                GetComponent<CanvasRenderer>().SetAlpha(0.5f);
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
        links.description.GetComponent<UnityEngine.UI.Text>().text = description;
	}
	
	void Update () {

	}

    public void OnClick() {
        Debug.Log(name + " Clicked");
        disabled = !disabled_variable;
    }
}
