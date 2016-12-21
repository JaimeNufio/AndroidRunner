using UnityEngine;
using System.Collections;

public class ControlBird : MonoBehaviour {

	public int healthTest;
	public float yMin, yMax, xMin, xMax, speed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (healthTest > -1) { 
			Game_.health = healthTest;
		}

		Vector3 accel = Input.acceleration;
		Vector3 shift = new Vector3 (accel.x, accel.y,0);

		Vector3 GoTo = transform.position + shift;
		if ((GoTo.x < xMax && GoTo.y < yMax) && (GoTo.x > xMin && GoTo.y > yMin)) {
			transform.position = Vector3.Lerp (transform.position, GoTo, speed * Time.deltaTime);
		}

		transform.localRotation = Quaternion.identity;

	}
}
