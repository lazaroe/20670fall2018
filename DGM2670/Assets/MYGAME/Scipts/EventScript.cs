using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour {

	public UnityEvent Event;
	public UnityEvent Stop;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	}
	private void OnTriggerExit(Collider other)
	{
		Stop.Invoke();
	}
}

//Event for Particles on JetPack
