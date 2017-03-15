using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveHud : MonoBehaviour {

	public Vector3 goTo;
	public float speed,dst;
	public bool moving;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			transform.localPosition = Vector3.Lerp (goTo,transform.position, speed * Time.deltaTime);
			if (Vector3.Magnitude (transform.position - goTo) < dst) {
				moving = false;
			}
		}
	}
}
