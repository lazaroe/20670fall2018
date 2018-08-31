using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyDownEvent : MonoBehaviour {

	public UnityEvent Event;

	 private void Update():
		{
		Event.Invoke();
		}
}
