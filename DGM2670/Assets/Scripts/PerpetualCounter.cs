using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PerpetualCounter : MonoBehaviour {
	
	public UnityEvent OnCount;
	public float seconds = 1;
	IEnumerator Start (){
		while (true)
		{
			OnCount.Invoke();
			yield return new WaitForSeconds(seconds);
		}
	}
}
