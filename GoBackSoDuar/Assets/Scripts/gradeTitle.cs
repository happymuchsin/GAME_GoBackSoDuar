using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gradeTitle : MonoBehaviour {

	public Text healthText;
	int grade;
	// Use this for initialization
	void Start () {
		grade = Player.health;

		if(grade == 0) {
			healthText.text = "DUARRR GAME OVER";
		}
		else if(grade == 1) {
			healthText.text = "UNTUNG MASIH SATU";
		}
		else if(grade == 2) {
			healthText.text = "LAH MEPET";
		}
		else if(grade == 3) {
			healthText.text = "LUMAYAN";
		}
		else if(grade == 4) {
			healthText.text = "SATUNYA SIAPA KOK MATI?";
		}
		else if(grade == 5) {
			healthText.text = "DEWA";
		}
		else {
			
		}
		//healthText.text = grade.ToString("n2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
