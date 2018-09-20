using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTank : MonoBehaviour {

	public int[] watertank = {5};
	public int watertankcapacity = 100;

	void Update ()
	{
		while(watertankcapacity > 1)
		{
			Debug.Log(watertankcapacity);
			watertankcapacity--; 
		}
	}

}
