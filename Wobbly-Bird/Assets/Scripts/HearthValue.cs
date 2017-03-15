using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HearthValue : MonoBehaviour {

	public Sprite[] phases = new Sprite[3];
	public int Value = 2;

	Image theHeart;

	void Start(){
		theHeart = transform.GetComponent (typeof(Image)) as Image;
	}

	void Update () {
		if (Value >= 0 && Value <= 2) {
			theHeart.sprite = phases [Value];
		}
	}
}
