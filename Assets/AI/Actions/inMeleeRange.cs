using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class inMeleeRange : RAINAction
{
	public inMeleeRange()
	{
		actionName = "Animator: touch = true";
	}
	
	public override ActionResult Execute(AI ai)

	{
		facingDirection FacingDirection = ai.Body.GetComponent<facingDirection>();
		Animator animator = FacingDirection.animator;
		animator.SetBool ("touch", true);
		animator.SetBool ("sneeze", false);

		return ActionResult.RUNNING;
	}
}