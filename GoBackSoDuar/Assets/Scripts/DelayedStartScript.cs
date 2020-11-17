using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStartScript : MonoBehaviour {

	public GameObject CountDown, LEVEL;
	// Use this for initialization
	void Start () {
		StartCoroutine("StartDelay");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator StartDelay() {
		Time.timeScale = 0;
		float pauseTime = Time.realtimeSinceStartup + 3f;
		while (Time.realtimeSinceStartup < pauseTime)
			yield return 0;
		CountDown.gameObject.SetActive(false);
		LEVEL.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
}
