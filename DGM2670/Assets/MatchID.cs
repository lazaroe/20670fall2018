using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MatchID : MonoBehaviour 
{
	public NameID ID;
	public UnityEvent OnMatch;
	private void Invoke (NameID id)
	{
		if (id == ID)
		{
			OnMatch.Invoke();
			print("match");
		}
	}
}
