using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

	public Transform Spawnpoint;
	public GameObject Prefab;
	public int maxAmmo;
	private int currentAmmo;
	public float reloadTime = 1f;

	private bool isReloading = false;

	void Start ()
	{
		currentAmmo = maxAmmo;
	}

	void Update ()
	
	{
		if (isReloading)
		return;

		if (currentAmmo <= 0)
		{
			StartCoroutine(Reload());
			return;
		}
	}

	IEnumerator Reload ()
	{
		isReloading = true;
		Debug.Log("Reloading..");
		yield return new WaitForSeconds(reloadTime);
		currentAmmo = maxAmmo;
		isReloading = false;
	}
	
	//public virtual void Invoke(CharacterController controller, Transform transform)
	 	void OnMouseDown()
			{
		Prefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
		Destroy(Prefab, 2.0f);
			}
	
}