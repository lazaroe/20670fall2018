using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour {

	Text text;
	public FloatData ammoAmount;

	void Start ()
	{
		text = GetComponent<Text> ();
		ammoAmount.value = 0;
	}

	void Update ()
	{
		if (ammoAmount.value > 0)
		 text.text = "Ammo" + ammoAmount.value;
		 else
		 text.text = "Out of Ammo!";
	}
}
