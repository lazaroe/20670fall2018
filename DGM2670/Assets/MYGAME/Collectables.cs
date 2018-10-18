using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour {

	public int destroyTime = 4;
	void Update () 
	{

        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        Destroy (gameObject, destroyTime);
	}
}
