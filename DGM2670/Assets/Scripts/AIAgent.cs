using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIAgent : MonoBehaviour {

	private NavMeshAgent agent;
	public Transform Destination;
	public Transform PostPoint;
	private Transform FinalDestination;
	public FloatData Speed;
	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		agent.speed = Speed.Value;
		FinalDestination = transform;
	}
	private void OnTriggerEnter(Collider obj)
	{
		if(obj.transform == Destination)
		FinalDestination = Destination;
	}
	private void OnTriggerExit(Collider obj)
	{
		FinalDestination = PostPoint;
	}
	
	private void Update ()
	{
		agent.destination = FinalDestination.position;
	
	}
}
