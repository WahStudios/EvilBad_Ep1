using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler{

    public Item item;
    Image itemImage;
    public int slotNumber;
    Inventory inventory;

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

        if(inventory.Items[slotNumber].itemName != null)
        {
            Debug.Log("spritenotlaoding");
            itemImage.enabled = true;
            itemImage.sprite = inventory.Items[slotNumber].ItemIcon;

        }
        else
        {
            
            itemImage.enabled = false;
        }
    }
	public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Clicked");
    }

	public void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("MouseOver");
    }

   
}
