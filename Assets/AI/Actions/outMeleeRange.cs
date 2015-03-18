using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class outMeleeRange : RAINAction
{
	public outMeleeRange()
	{
		actionName = "Animator: touch = false";
	}
	
	public override ActionResult Execute(AI ai)
	{
		facingDirection FacingDirection = ai.Body.GetComponent<facingDirection>();
		Animator animator = FacingDirection.animator;
		animator.SetBool ("touch", false);
		animator.SetBool ("sneeze", true);


		return ActionResult.RUNNING;
	}


}