using UnityEngine;
using System.Collections;

public class KillBlock : MonoBehaviour {

	public GameObject[] rewards = new GameObject[5];
	public GameObject fluFlap;

	float timer,max;

	void OnCollisionEnter2D(Collision2D thing){
		//Debug.Log ("KILL");
		Game_.currentSpeed+=.01f;
		Destroy (thing.transform.gameObject);
	}

	void Start(){
		max = Game_.currentSpeed;
	}

	void Update(){
		timer += Time.deltaTime;

		if (timer > max && Game_.health > 0) {
			timer = 0;
			if (Random.Range (0, 10) < 6.5f) {
				Vector3 pos = new Vector3 (Random.Range (12, 20), Random.Range (-4.5f, 4.5f), 0);
				GameObject newThing = (GameObject)Instantiate (fluFlap, pos, Quaternion.identity);
				FlyLeft comp = newThing.GetComponent (typeof(FlyLeft)) as FlyLeft;
				comp.Freq = Random.Range (2, 6);
				comp.yMovement = Random.Range (1, 3);
				comp.xMovement = Random.Range (-10, -3);
			} else {
				Vector3 pos = new Vector3 (Random.Range (12, 20), Random.Range (-4.5f, 4.5f), 0);
				GameObject thing = rewards[(int) Mathf.Floor(Random.Range(0,rewards.Length))];
				GameObject newThing = (GameObject)Instantiate (thing, pos, Quaternion.identity);
				BonusMoveLeft comp = newThing.GetComponent (typeof(BonusMoveLeft)) as BonusMoveLeft;
				comp.Freq = Random.Range (2, 6);
				comp.yMovement = Random.Range (1, 3);
				comp.xMovement = Random.Range (-10, -3);
			}
		}
	}

}
