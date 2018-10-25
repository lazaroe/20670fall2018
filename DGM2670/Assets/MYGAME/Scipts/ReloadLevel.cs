using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadLevel : MonoBehaviour {

	void OnTriggerEnter(Collider Player)
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
