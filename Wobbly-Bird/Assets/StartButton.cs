using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public Text title,instruction,hud;

	public void StartGame () {
		title.enabled = false;
		for( int i = 0; i < title.transform.childCount; ++i )
		{
			title.transform.GetChild(i).gameObject.SetActiveRecursively(false);
		}
		instruction.enabled = false;
		for( int i = 0; i < instruction.transform.childCount; ++i )
		{
			instruction.transform.GetChild(i).gameObject.SetActiveRecursively(false);
		}
		hud.enabled = true;
	}

	public void RestartGame(){
		SceneManager.LoadScene ("test");
	}

	public void ShowInstructions(){
		title.enabled = false;
		for( int i = 0; i < title.transform.childCount; ++i )
		{
			title.transform.GetChild(i).gameObject.SetActiveRecursively(false);
		}
		instruction.enabled = true;
	}


}
