using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHorizontal1 : MonoBehaviour {

	[SerializeField]
	public float moveSpeed;
	[SerializeField]Transform[] waypoints;
	public bool MoveRight;
	int waypointsIndex = 0;
	public Animator animator;

	private Transform target;

	int IsRunning = 1;
	float NumberofSeconds = 0.5f;
	float Timer = 0;
	int m;
	
	// Use this for initialization
	void Start () {
		transform.position = waypoints [waypointsIndex].transform.position;
		target = GameObject.FindGameObjectWithTag("playerTag").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (IsRunning == 1) {
			StartCoroutine(Wait());		
		}

		if(m < 2) {
		if(MoveRight) {
			transform.Translate(2 * Time.deltaTime * moveSpeed, 0,0);
			transform.localScale = new Vector2(0.45f,0.45f);
		}}

		if(m == 2 || m <= 5) {
		if(!MoveRight) {
			transform.Translate(-0 * Time.deltaTime * moveSpeed, 0,0);
			transform.localScale = new Vector2(-0.45f,0.45f);
		}}
		// Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);

		// animator.SetFloat("Horizontal", movement.x);

		// transform.position = transform.position + movement * moveSpeed * Time.deltaTime;
		
		if(Vector2.Distance(transform.position, target.position) < 3){
			transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
		}
		else if (Vector2.Distance(transform.position, target.position) > 0.5f){
			Move ();
		}
	}

	void Move () {
		transform.position = Vector2.MoveTowards(transform.position, 
		waypoints[waypointsIndex].transform.position, moveSpeed * Time.deltaTime);
		
		if (transform.position == waypoints[waypointsIndex].transform.position) {
			waypointsIndex += 1;
		}

		if (waypointsIndex == waypoints.Length) {
			waypointsIndex = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.CompareTag("node78")){
			if(MoveRight) {
				MoveRight = false;
			}
			else {
				MoveRight = true;
			}
		}
	}

	IEnumerator Wait() {
		IsRunning = 0;
		while(Timer < 10000) {
			yield return new WaitForSeconds(NumberofSeconds);
			Timer += NumberofSeconds;
			m = Random.Range (1, 5);
		}
		IsRunning = 1;
		
	}
}
