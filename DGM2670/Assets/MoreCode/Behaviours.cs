using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Behaviours : MonoBehaviour {
	
	public UnityEventQueueSystem OnAwake, OnStart, TriggerEnter, CollisionEnter;

	private void Awake()
	{
		OnAwake.Invoke;
	}

	void Start ()
	{
		OnStart.Invoke;
	}
	
	private void OnTriggerEnter(Collider other)
	{
		TriggerEnter.Invoke;
	}

	private void OnCollisionEnter (Collision other)
	{
		CollisionEnter.Invoke;
	}

	private void Ondestroy ()
	{
		
	}

}
