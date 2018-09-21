using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScripts : MonoBehaviour {

	public MovePattern Car;
	public MovePattern Airplane;
	private CharacterController controller;

	private void Start ()
	{
		controller = GetComponent<CharacterController>();
		Car = GetComponent<MovePattern>();
		Airplane = GetComponent<MovePattern>();
	}

	void Update()
	{

		if (controller.isGrounded)
		{
			//Car.enabled = !Car.enabled;
			Car.Invoke(controller, transform);
		}
		else
		{
			Airplane.Invoke(controller, transform);
		}
	}

}
