using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "MovePatternDual")]
public class MovePatternDual : MovePattern {

	public override void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			Move(transform);
		}
		Move(controller);
	}
	
}
