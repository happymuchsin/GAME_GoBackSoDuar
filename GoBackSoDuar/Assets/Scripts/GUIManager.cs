using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

	public static int sceneLevel;
	// Use this for initialization
	void Start () {

	}

	public void OnVersusBot()
	{
		SceneManager.LoadScene("Main");
	}

	public void OnVersusPlayer()
	{
		SceneManager.LoadScene("Main");
	}

	public void On1Player()
	{
		SceneManager.LoadScene("Main");
	}

	public void On5Player()
	{
		SceneManager.LoadScene("Main");
	}

	public void OnResume()
	{
		
	}

	public void OnMainMenu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void OnPause()
	{
		
	}

    public void OnSinglePlayer()
    {
        SceneManager.LoadScene("SinglePlayer");
    }

    public void OnMultiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }

	public void Level1()
	{
		SceneManager.LoadScene("Main");
		sceneLevel = 1;
	}

	public void Level2()
	{
		SceneManager.LoadScene("MainLevel2");
		sceneLevel = 2;
	}

	public void Level3()
	{
		SceneManager.LoadScene("MainLevel3");
		sceneLevel = 3;
	}

	public void Level4()
	{
		SceneManager.LoadScene("MainLevel4");
		sceneLevel = 4;
	}

	public void Level5()
	{
		SceneManager.LoadScene("MainLevel5");
		sceneLevel = 5;
	}

	public void OnRetry()
	{
		switch(sceneLevel) {
			case 1:
			SceneManager.LoadScene("Main");
			break;
			case 2:
			SceneManager.LoadScene("MainLevel2");
			break;
			case 3:
			SceneManager.LoadScene("MainLevel3");
			break;
			case 4:
			SceneManager.LoadScene("MainLevel4");
			break;
			case 5:
			SceneManager.LoadScene("MainLevel5");
			break;
		}
	}

    // Update is called once per frame
    void Update () {
		
	}
}
