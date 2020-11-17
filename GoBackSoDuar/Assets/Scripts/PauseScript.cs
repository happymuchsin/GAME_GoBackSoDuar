using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

	public GameObject panelPause;

	public void PauseControl() {
		if (Time.timeScale == 1) {
			panelPause.SetActive(true);
			Time.timeScale = 0;
		}
		else {
			Time.timeScale = 1;
			panelPause.SetActive(false);
		}
	}

	public void MainMenu() {
		SceneManager.LoadScene("Menu");
	}
}
