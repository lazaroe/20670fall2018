using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathGas : MonoBehaviour {

public void update ()
{   
		transform.Translate(0f,1f*Time.deltaTime,0f);
}
	void OnCollisionEnter2D	(Collision2D col)
{
	if (gameObject.CompareTag("Player"))
    {
        gameObject.SetActive(false);
    }
}
}
