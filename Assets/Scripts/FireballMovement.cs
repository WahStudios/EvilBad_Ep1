using UnityEngine;
using System.Collections;

public class FireballMovement : MonoBehaviour {
	public bool isActive = false;
	public bool isLeftActive = false;
	public Vector3 startingPos;
	public Quaternion startingRot;
	//public GameObject leftFacingRotate;
	//public ObjectPool objectPool;
	// Use this for initialization
	void Start () {
		
		startingPos = transform.position;
		startingRot = transform.rotation;
	}

	public void FireRight(){

		isActive = true;
	}

	public void FireLeft(){
		isLeftActive = true;
	}
	// Update is called once per frame
	void Update () {

		if(isActive == true)
		{
			transform.rotation = startingRot;
			transform.Translate (Vector2.right * ObjectPool.fireBallSpeed);

		}

		if(isLeftActive == true)
		{
			transform.Translate (Vector2.right *  ObjectPool.fireBallSpeed);
			transform.rotation = ObjectPool.facingLeft.transform.rotation;
		}

		if(renderer.isVisible == false)
		{
			ResetObject ();
		}
	
	}

	void ResetObject(){
		isActive = false;
		isLeftActive = false;
		transform.position = startingPos;
		transform.rotation = startingRot;
		transform.Translate (Vector2.right * 0);
	}
}
