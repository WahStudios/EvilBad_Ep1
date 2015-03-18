using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class tabManager : MonoBehaviour {

	public GameObject inventory;
	public bool isClicked = false;
	public bool isActive = false;
	private Vector2 inventoryTrans;

	void Start()
	{
		inventoryTrans = inventory.gameObject.GetComponent<RectTransform>().anchoredPosition; 
	}
	// Use this for initialization
	void IsClicked(){
		isClicked = !isClicked;
		if(isClicked == true)
		{
			inventoryTrans.y = 21.9f;
			isActive = true;
		}
		else
		{
			inventoryTrans.y = 1000;
			isActive = false;
		}
		inventory.gameObject.GetComponent<RectTransform>().anchoredPosition = inventoryTrans;

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
