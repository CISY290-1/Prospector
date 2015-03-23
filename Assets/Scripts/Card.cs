using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {
	public string suit;
	public int rank;
	public Color color = Color.black;
	public string colS = "Black";

	public List<GameObject> decoGOs = new List<GameObject>();
	public List<GameObject> pipGOs = new List<GameObject>();

	public GameObject back; //back of card
	public CardDefinition def;//parsed from deck

	public bool faceUp{
		get{return(!back.activeSelf);}
		set{back.setActive(!value);}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public class Decorator{
	public string type;
	public Vector3 loc;
	public bool flip = false;
	public float scale = 1f;
}

[System.Serializable]
public class CardDefinition{
	public string face;
	public int rank;
	public List<Decorator> pips = new List<Decorator>();
}
