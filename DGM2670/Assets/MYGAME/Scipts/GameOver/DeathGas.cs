using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathGas : MonoBehaviour {
public GameObject DeathMenu;
public void update ()
{   
	transform.Translate(0f,5f,0f);
}
	void OnCollisionEnter(Collision col)
{
	if (col.gameObject.CompareTag("Player"))
    {
        col.gameObject.SetActive(false);
        DeathMenu.SetActive(true);
    }
}
}
