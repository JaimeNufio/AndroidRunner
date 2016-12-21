﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public Image[] lifeTotals = new Image[3];
	HearthValue Val1,Val2,Val3;
	Text muniesText;

	// Use this for initialization
	void Start () {
		Val1 = lifeTotals [0].GetComponent (typeof(HearthValue)) as HearthValue;
		Val2 = lifeTotals [1].GetComponent (typeof(HearthValue)) as HearthValue;
		Val3 = lifeTotals [2].GetComponent (typeof(HearthValue)) as HearthValue;
	}
	
	// Update is called once per frame
	void Update () {

		int health = Game_.health;
		muniesText.text = ""+Game_.munies;
		//Debug.Log ("Health: " + health);

		if (health >= 4) {
			Val1.Value = health - 4;
			Val2.Value = 2;
			Val3.Value = 2;
		} else if (health >= 2) {
			Val1.Value = 0;
			Val2.Value = health - 2;
			Val3.Value = 2;
		} else if (health >= 0) {
			Val1.Value = 0;
			Val2.Value = 0;
			Val3.Value = health;
		}

	}
}
