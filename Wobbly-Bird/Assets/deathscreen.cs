using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathscreen : MonoBehaviour {

	// Use this for initialization
	public Text hud,redo;
	// Update is called once per frame
	void Update () {
		if ( Game_.dead){
			Debug.Log ("Showing death screen");
			redo.gameObject.SetActive (true);
			hud.gameObject.SetActive (false);
			redo.text = "\nHighscore:\n" + PlayerPrefs.GetInt ("highscore") + "\nScore:\n" + Game_.munies;
		}
	}
}