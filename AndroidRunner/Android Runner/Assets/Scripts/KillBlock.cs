using UnityEngine;
using System.Collections;

public class KillBlock : MonoBehaviour {

	public GameObject fluFlap;
	float timer,max;

	void OnCollisionEnter2D(Collision2D thing){
		//Debug.Log ("KILL");
		Destroy (thing.transform.gameObject);
	}

	void Start(){
		max = Game_.currentSpeed;
	}

	void Update(){
		timer += Time.deltaTime;

		if (timer > max) {
			timer = 0;
			if (Random.Range (0, 10) < 8.5f) {
				Vector3 pos = new Vector3 (Random.Range (12, 20), Random.Range (-4.5f, 4.5f), 0);
				GameObject newThing = (GameObject)Instantiate (fluFlap, pos, Quaternion.identity);
				FlyLeft comp = newThing.GetComponent (typeof(FlyLeft)) as FlyLeft;
				comp.Freq = Random.Range (2, 6);
				comp.yMovement = Random.Range (1, 3);
				comp.xMovement = Random.Range (-7, -2);
			} else {
				Vector3 pos = new Vector3 (Random.Range (12, 20), Random.Range (-4.5f, 4.5f), 0);
				GameObject newThing = (GameObject)Instantiate (, pos, Quaternion.identity);
			}
		}
	}

}
