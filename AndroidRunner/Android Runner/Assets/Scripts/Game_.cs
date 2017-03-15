using UnityEngine;
using System.Collections;

public static class Game_ {

	public static int health = 6,munies = 0;
	public static float currentSpeed = 2f;
	public static bool dead = false;

	public static void SetCurrentSpeed(float timer){
		currentSpeed = timer;
	}

}
