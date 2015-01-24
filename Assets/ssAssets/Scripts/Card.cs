﻿using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {

    public string name;
    public Sprite image;
    public string description;

    /*public bool disabled {
        set {
            GetComponent<UnityEngine.UI.Button>().enabled = value;
        }
    }*/


    public bool disabled_variable = true;
    public bool disabled {
        set {
            disabled_variable = value;
            if (value)
            {
             //   GetComponent<UnityEngine.UI.Button>().interactable = true;
                GetComponent<Renderer>().SetAlpha(0.5f);
                
            }
            else
            {
              //  GetComponent<UnityEngine.UI.Button>().interactable = false;
                GetComponent<Renderer>().SetAlpha(1f);
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
        disabled = !disabled_variable;
    }
}