using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BasicMovement : MonoBehaviour {
	
	float moveSpeed = 7;
	public Animator animator;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 movement = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 
		CrossPlatformInputManager.GetAxis("Vertical"), 0.0f);

		animator.SetFloat("Horizontal", movement.x);
		animator.SetFloat("Vertical", movement.y);
		animator.SetFloat("Magnitude", movement.magnitude);

		transform.position = transform.position + movement * moveSpeed * Time.deltaTime;
	}

	void FixedUpdate () {
		
	}
}
