using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour {

	public UnityEvent MyEvent;
	
	private void Start()
	{
	    MyEvent.Invoke();
	}
}
