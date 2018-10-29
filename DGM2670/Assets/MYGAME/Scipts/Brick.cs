using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	//public float destroyTime = 2f;

	public float jumpForce = 10f;

	void OnCollisionEnter(Collision collision)
	{
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
			if (rb != null)
			{
				Vector3 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}
	}
	/*void Start()
	{
		Destroy (gameObject, destroyTime);
	}*/
}