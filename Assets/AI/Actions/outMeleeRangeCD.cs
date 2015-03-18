using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class outMeleeRangeCD : RAINAction
{
	public outMeleeRangeCD()
	{
		actionName = "Animator: sneeze = false";
	}
	
	public override ActionResult Execute(AI ai)
	{
		facingDirection FacingDirection = ai.Body.GetComponent<facingDirection>();
		Animator animator = FacingDirection.animator;
		animator.SetBool ("touch", false);
		animator.SetBool ("sneeze", false);
		
		
		return ActionResult.RUNNING;
	}
}