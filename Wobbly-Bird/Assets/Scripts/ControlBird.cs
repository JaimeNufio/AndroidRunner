using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlBird : MonoBehaviour {

	public int healthTest;
	public float yMin, yMax, xMin, xMax, speed;
	public RectTransform Score,HUD,Title;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (healthTest > -1) { 
			Game_.health = healthTest;
		}

		Vector3 accel = Input.acceleration;
		Vector3 shift = new Vector3 (accel.x*2, accel.y*2,0);

		Vector3 GoTo = transform.position + shift;
		if ((GoTo.x < xMax && GoTo.y < yMax) && (GoTo.x > xMin && GoTo.y > yMin) && !Game_.dead) {
			transform.position = Vector3.Lerp (transform.position, GoTo, speed * Time.deltaTime);
		}

		if (Game_.dead) {
			Rigidbody2D bard = transform.GetComponent (typeof(Rigidbody2D)) as Rigidbody2D;
			bard.gravityScale = 1;
		}

		transform.localRotation = Quaternion.identity;

	}
}
