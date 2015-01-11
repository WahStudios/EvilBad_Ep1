using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class tabManager : MonoBehaviour {

	public GameObject inventory;
	public bool isClicked = false;
	public bool isActive = false;

	// Use this for initialization
	void IsClicked(){
		isClicked = !isClicked;
		if(isClicked == true)
		{
			inventory.SetActive (true);
			isActive = true;
		}
		else
		{
			inventory.SetActive (false);
			isActive = false;
		}

	}
/*	// Update is called once per frame
	void Update () {
		
		if(isClicked == true)
		{
			inventory.SetActive (true);
			isClicked = false;
		}
		else
		{
			inventory.SetActive (false);
		}

	}
*/
}
