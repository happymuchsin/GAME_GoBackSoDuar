using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	
	public GameObject heart1, heart2, heart3, heart4, heart5, finishLine, destruc;
	public static int health;
	public Vector3 startPosition;
	public AudioClip playerdeath;
	public AudioClip levelcomplete;
	// Use this for initialization
	void Awake () {
		startPosition = transform.position;
	}
	void Start () {
		health = 5;
		heart1 = GameObject.Find("heart1");
		heart2 = GameObject.Find("heart2");
		heart3 = GameObject.Find("heart3");
		heart4 = GameObject.Find("heart4");
		heart5 = GameObject.Find("heart5");
		heart1.gameObject.SetActive(true);
		heart2.gameObject.SetActive(true);
		heart3.gameObject.SetActive(true);
		heart4.gameObject.SetActive(true);
		heart5.gameObject.SetActive(true);
		finishLine = GameObject.Find("finishLine");
		destruc = GameObject.Find("destruc");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "enemyTag") {
			Instantiate (destruc, transform.position, Quaternion.identity);
			health -= 1;
			switch(health) {
				case 4:
				SoundManager.instance.PlaySFX("Bomb");
				//AudioSource.PlayClipAtPoint(playerdeath, transform.position);
				heart5.gameObject.SetActive(false);
				transform.position = startPosition;
				break;
				case 3:
				SoundManager.instance.PlaySFX("Bomb");
				//AudioSource.PlayClipAtPoint(playerdeath, transform.position);
				heart4.gameObject.SetActive(false);
				transform.position = startPosition;
				break;
				case 2:
				SoundManager.instance.PlaySFX("Bomb");
				//AudioSource.PlayClipAtPoint(playerdeath, transform.position);
				heart3.gameObject.SetActive(false);
				transform.position = startPosition;
				break;
				case 1:
				SoundManager.instance.PlaySFX("Bomb");
				//AudioSource.PlayClipAtPoint(playerdeath, transform.position);
				heart2.gameObject.SetActive(false);
				transform.position = startPosition;
				break;
				case 0:
				SoundManager.instance.PlaySFX("Player death");
				//AudioSource.PlayClipAtPoint(playerdeath, transform.position);
				heart1.gameObject.SetActive(false);
				SceneManager.LoadScene("GradeSingle");
				break;
			}
		}
		if (coll.gameObject.tag == "finishLineTag") {
			SoundManager.instance.PlaySFX("Level completed");
			//AudioSource.PlayClipAtPoint(levelcomplete, transform.position);
			SceneManager.LoadScene("GradeSingle");
		}
	}
}
