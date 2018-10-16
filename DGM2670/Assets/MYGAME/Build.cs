using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

	public Transform Spawnpoint;
	public GameObject Prefab;

	void OnMouseDown()
	{
		Prefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
		Destroy(Prefab, 2.0f);
	}
	
}