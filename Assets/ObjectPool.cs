using UnityEngine;
using System.Collections;

public class ObjectPool : MonoBehaviour {

	public GameObject[] fireBallList;
	public FireballMovement[] fireBallMovement;
	public int fireBallMaxNumber = 4;
	public static float fireBallSpeed = 0.5f;
	public float fireBallFireRate = 2;
	public static GameObject facingLeft;
	public GameObject leftFacingObject;

	// Use this for initialization
	void Start () {

		facingLeft = leftFacingObject;

	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
