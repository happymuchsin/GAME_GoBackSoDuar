﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveHorizontal : MonoBehaviour {

	[SerializeField]
	public float moveSpeed;
	[SerializeField]Transform[] waypoints;
	int waypointsIndex = 0;
	public Animator animator;
	
	// Use this for initialization
	void Start () {
		transform.position = waypoints [waypointsIndex].transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		// Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);

		// animator.SetFloat("Horizontal", movement.x);

		// transform.position = transform.position + movement * moveSpeed * Time.deltaTime;
		Move ();	
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
