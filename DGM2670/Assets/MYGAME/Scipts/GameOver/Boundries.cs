using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour {

	public GameObject DeathMenu;
	void OnCollisionEnter(Collision col)
{
	if (col.gameObject.CompareTag("Player"))
    {
        col.gameObject.SetActive(false);
        DeathMenu.SetActive(true);
    }
}
}
