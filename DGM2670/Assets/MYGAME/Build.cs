using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Build : MonoBehaviour
{

	public Transform Spawnpoint;
	public GameObject Prefab;
	public FloatData ammoAmount;
	//public int maxAmmo;
	//private int currentAmmo;
	//public float reloadTime = 1f;

	private bool isReloading = false;

	/*void Start ()
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
	//different form of shooting and reloading
	/*IEnumerator Reload ()
	{
		isReloading = true;
		Debug.Log("Reloading..");
		//yield return new WaitForSeconds(reloadTime);
		currentAmmo = maxAmmo;
		isReloading = false;
	}
	*/
	//public virtual void Invoke(CharacterController controller, Transform transform)
	 	void OnMouseDown()
			{
				if (ammoAmount.value > 0)
				{
		Prefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
		Destroy(Prefab, 2.0f);
				}
			}
	
}