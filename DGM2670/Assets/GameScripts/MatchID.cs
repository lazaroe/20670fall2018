using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MatchID : MonoBehaviour 
{
	public NameID ID;
	public UnityEvent OnMatch;

	private void OnTriggerEnter(Collider other)
	{
		var id = other.GetComponent<ObjectID>().ID;
		Call(id);
	}
	private void Call(NameID id)
	{
		if (id == ID)
		{
			OnMatch.Invoke();
		}
	}
}
