using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


//	void OnTriggerEnter (Collider col)
	//{
	//	GameControl.moneyAmount += 1;
	//	Destroy (gameObject);
	//}
	public FloatData CoinAmount;

	void OnTriggerEnter (Collider col)
	{
		GameControl.moneyAmount += CoinAmount.value;
		Destroy (gameObject);
	}
}
