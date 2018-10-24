using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour {

	public int destroyTime = 4;
	private int count;
    public FloatData ammoAmount;
	void Update () 
	{
		//This will make the object rotate as it falls down
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        Destroy (gameObject, destroyTime);
	}

	void OnTriggerEnter(Collider other) 
    {
	    //This will make the object dissapear
        if (other.gameObject.CompareTag ("Player"))
        {
            ammoAmount.value += 6;
            Destroy (gameObject);

        }
    }
}
