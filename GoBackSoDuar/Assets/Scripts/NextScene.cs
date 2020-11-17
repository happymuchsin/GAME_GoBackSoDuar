using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("SceneDelay");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SceneDelay() {
		Time.timeScale = 0;
		float pauseTime = Time.realtimeSinceStartup + 2f;
		while (Time.realtimeSinceStartup < pauseTime)
			yield return 0;
		SceneManager.LoadScene("Menu");
		Time.timeScale = 1;
	}
}
