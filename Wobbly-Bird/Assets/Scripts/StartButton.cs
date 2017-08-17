using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public Text title,instruction,hud;

	public void StartGame () {
		title.gameObject.SetActive(false);
		instruction.gameObject.SetActive (false);
		hud.gameObject.SetActive(true);
		Game_.gameStarted = true;
	}

	public void RestartGame(){
		SceneManager.LoadScene ("test");
		Game_.health = 6;
		Game_.dead = false;
		Game_.gameStarted = true;
		Game_.munies = 0;
	}

	public void ShowInstructions(){
		Debug.Log("ok");
		instruction.gameObject.SetActive(true);
		title.gameObject.SetActive (false);
		/*title.enabled = false;
		for( int i = 0; i < title.transform.childCount; ++i )
		{
			title.transform.GetChild (i).gameObject.SetActive (false); //.SetActiveRecursively(false);
		}*/

	}
		


}
