using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class navigationButtonsController : MonoBehaviour {

	public void onPlayClicked(){
		SceneManager.LoadScene ("mainScene");
	}

	public void onPauseClicked() {
		Time.timeScale = 0;

	}

	public void onMenuClicked(){
		SceneManager.LoadScene ("menuScene");
	}

	public void onSettingsClicked() {
		SceneManager.LoadScene ("settingsScene");
	}

	public void onExitClicked() {
		Application.Quit ();
	}
}
