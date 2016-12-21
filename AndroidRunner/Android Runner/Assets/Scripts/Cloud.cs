using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

	public Sprite[] Sprites = new Sprite[3];
	float speed = 1,zPos;

	// Use this for initialization
	void Start () {
		speed = Random.Range (1,3);
		if (speed > 1) {
			zPos = -1;
		} else {
			zPos = 1;
		}

		transform.position = new Vector3 (Random.Range(11,25),Random.Range(-5f,5f),zPos);
		SpriteRenderer CloudSprite = transform.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer;
		int Place = (int)Mathf.Floor (Random.Range (0, 2.9f));

		CloudSprite.sprite = Sprites[Place];
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-.05f*speed,0,0);
		if (transform.position.x < -10.5f) {
			Start ();
		}
	}
}
