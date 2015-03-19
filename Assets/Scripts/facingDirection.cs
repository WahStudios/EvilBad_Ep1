using UnityEngine;
using System.Collections;
using RAIN.Core;
using RAIN.Memory;
using RAIN.Perception;



public class facingDirection : MonoBehaviour {

	public AIRig aiRig;
	public Vector2 jumpVector;
	Quaternion rot;
	GameObject seenObject;
	public Animator animator;
	public bool isGrounded;                 //ground switch, handled by ground check function
	public Transform grounder;   
	public float radiuss = 0.5f;
	public LayerMask ground;  
	public BoxCollider2D distanceTrigger;
	bool isSeen = false;
	bool meleeRange = false;


	//object that checks for the ground, child 
	// Use this for initialization
	void Start () {

	}
	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(grounder.transform.position, radiuss);
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			//meleeRange = true;
		}
	}
	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			//Debug.Log ("enter");
			//if(meleeRange == true){
			aiRig.AI.WorkingMemory.SetItem<bool>("meleeRange", true);
			meleeRange = true;
			//}
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
		//	Debug.Log ("exit");
			meleeRange = false;
			aiRig.AI.WorkingMemory.SetItem<bool>("meleeRange", false);
		}
	}
	// Update ris called once per frame
	void Update () {

		if(animator.GetCurrentAnimatorStateInfo(0).IsName ("Ghoul_Sneeze"))
		{
			animator.SetBool("sneeze", false);
		}
		else if(animator.GetCurrentAnimatorStateInfo(0).IsName ("Paralyze Touch") || animator.GetCurrentAnimatorStateInfo(0).IsName ("Paralyze Jump")){
			animator.SetBool("touch", false);
		}

		if(aiRig.AI.Body.rigidbody2D.velocity.y > (0.2f) || aiRig.AI.Body.rigidbody2D.velocity.y < (-0.2f))
		{
			animator.SetBool ("jump", true);
			animator.SetFloat ("velocityY", aiRig.AI.Body.rigidbody2D.velocity.y);
		}
		else if(aiRig.AI.Body.rigidbody2D.velocity.y < 0.2f && aiRig.AI.Body.rigidbody2D.velocity.y > (-0.2f))
		{
			animator.SetBool ("jump", false);
			animator.SetFloat ("velocityY", aiRig.AI.Body.rigidbody2D.velocity.y);
		}


		if(aiRig.AI.WorkingMemory.GetItem<GameObject>("seen") != null)
		//if(aiRig.AI.Senses.GetSensor("eyes").)
		{
			if(isSeen == false){
			aiRig.AI.WorkingMemory.SetItem<bool>("wasSeen", true);
				isSeen = true;
			}
			isGrounded = Physics2D.OverlapCircle(grounder.transform.position, radiuss, ground);
			if(isGrounded == true){
				if(meleeRange == true){
				if(aiRig.AI.Motor.MoveTarget.Position.y > 2){
					//Debug.Log ("yo");
					aiRig.AI.Body.rigidbody2D.AddForce(jumpVector, ForceMode2D.Force);
				}
			}
			}
			if(aiRig.AI.Motor.MoveTarget.Position.x <= aiRig.AI.Body.gameObject.transform.position.x){
				
				rot.y = 180;
			}
			else
			{
				
				rot.y = 0;
			}
			aiRig.AI.Body.transform.rotation = rot;


		}
		else if(aiRig.AI.WorkingMemory.GetItem <GameObject>("seen") == null)
		//else //if(aiRig.AI.Senses.GetSensor("eyes").IsDetected(GameObject, "EvilBad"))
		{
//			Debug.Log ("wasSeenFalse");
			aiRig.AI.WorkingMemory.SetItem<bool>("wasSeen", false);
			isSeen = false;
		}
		if(aiRig.AI.WorkingMemory.GetItem<bool>("isWaypoint") == true)
		{
			if(aiRig.AI.Motor.MoveTarget.Position.x <= aiRig.AI.Body.gameObject.transform.position.x){
				
				rot.y = 180;
			}
			else
			{
				
				rot.y = 0;
			}
			aiRig.AI.Body.transform.rotation = rot;
		}


	}
}
