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
        Destroy (gameObject, destroyTime);
	}

	void OnTriggerEnter2D (Collider2D other) 
    {
	    //This will make the object dissapear
        if (other.gameObject.CompareTag ("Player"))
        {
            ammoAmount.value += 6;
            Destroy (gameObject);

        }
    }
}
