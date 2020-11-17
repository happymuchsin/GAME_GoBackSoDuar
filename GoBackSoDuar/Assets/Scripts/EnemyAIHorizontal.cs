using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIHorizontal : MonoBehaviour {

	[SerializeField]
	public float moveSpeed;
	[SerializeField]Transform[] waypoints;
	int waypointsIndex = 0;
	public Animator animator;

	private Transform target;
	
	// Use this for initialization
	void Start () {
		transform.position = waypoints [waypointsIndex].transform.position;
		target = GameObject.FindGameObjectWithTag("playerTag").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

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
}
