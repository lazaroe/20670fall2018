using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DoodeMove : MonoBehaviour {

	public float movementSpeed = 10f;

	Rigidbody rb;

	float movement = 0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector3 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
