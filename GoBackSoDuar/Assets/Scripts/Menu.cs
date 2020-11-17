using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;
	public GameObject optionsMenuHolder;
	public GameObject creditsMenuHolder;
	public GameObject helpMenuHolder;
	public GameObject startGameHolder;
	void Start() {


	}

	public void StartMenu() {
		mainMenuHolder.SetActive (false);
		optionsMenuHolder.SetActive (false);
		creditsMenuHolder.SetActive (false);
		helpMenuHolder.SetActive (false);
		startGameHolder.SetActive (true);
	}

	public void Exit() {
		Application.Quit ();
	}

	public void OptionsMenu() {
		mainMenuHolder.SetActive (false);
		optionsMenuHolder.SetActive (true);
		creditsMenuHolder.SetActive (false);
		helpMenuHolder.SetActive (false);
		startGameHolder.SetActive (false);
	}

	public void CreditsMenu() {
		mainMenuHolder.SetActive (false);
		optionsMenuHolder.SetActive (false);
		creditsMenuHolder.SetActive (true);
		helpMenuHolder.SetActive (false);
		startGameHolder.SetActive (false);
	}

	public void HelpMenu() {
		mainMenuHolder.SetActive (false);
		optionsMenuHolder.SetActive (false);
		creditsMenuHolder.SetActive (false);
		helpMenuHolder.SetActive (true);
		startGameHolder.SetActive (false);
	}

	public void BackMainMenu() {
		mainMenuHolder.SetActive (true);
		optionsMenuHolder.SetActive (false);
		creditsMenuHolder.SetActive (false);
		helpMenuHolder.SetActive (false);
		startGameHolder.SetActive (false);
	}
}
