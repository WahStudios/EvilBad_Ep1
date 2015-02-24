using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler{

    public Item item;
    Image itemImage;
    public int slotNumber;
    Inventory inventory;
	public EvilBadStats evilBadStats;
	// Use this for initialization
	void Start () {
		evilBadStats = GameObject.FindGameObjectWithTag("Player").GetComponent<EvilBadStats>();
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {


        if(inventory.Items[slotNumber].itemName != null)
        {
           
			item = inventory.Items[slotNumber];
            itemImage.enabled = true;
            itemImage.sprite = inventory.Items[slotNumber].ItemIcon;




        }
        else
        {
            
            itemImage.enabled = false;
        }


    }


	public void OnDrag(PointerEventData data)
	{
		if(inventory.Items[slotNumber].itemName != null)
		{
			inventory.showDraggedItem(inventory.Items[slotNumber], slotNumber);
			inventory.Items[slotNumber] = new Item();
		}
	}

	public void OnPointerDown(PointerEventData data)
    {
        if(inventory.Items[slotNumber].itemName == null && inventory.draggingItem)
		{
			inventory.Items[slotNumber] = inventory.draggedItem;
			inventory.closeDraggedItem();
		}
		else if(inventory.draggingItem && inventory.Items[slotNumber].itemName != null)
		{
			inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
			inventory.Items[slotNumber] = inventory.draggedItem;
			inventory.closeDraggedItem();
		}

		if(Input.GetMouseButtonDown(1))
		{
			//Debug.Log (item.itemType);
			if(item.itemType == "Weapon"){
				if(evilBadStats.isEquippedWeapon == false){
					GameObject weaponObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
					evilBadStats.equippedWeapon = weaponObject;
					evilBadStats.equipWeapon = true;
					//evilBadStats.SendMessage ("OnWeaponEquipped");
				}
				else
				{
					evilBadStats.equipWeapon = false;
					//evilBadStats.SendMessage("OnWeaponUnEquipped");
					//evilBadStats.equippedWeapon = null;
				}
			}
			else if(item.itemType == "Armor"){
				if(evilBadStats.isEquippedArmor == false){
					GameObject armorObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedArmor = armorObject;
					evilBadStats.equipArmor = true;

					//evilBadStats.SendMessage ("OnArmorEquipped");
				}
				else
				{
					//evilBadStats.SendMessage("OnArmorUnEquipped");
					evilBadStats.equipArmor = false;
					//evilBadStats.equippedArmor = null;
				}
			}
			else if(item.itemType == "Neck"){
				if(evilBadStats.isEquippedNeck == false){
					GameObject neckObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedNeck = neckObject;
					evilBadStats.equipNeck = true;

					//evilBadStats.SendMessage ("OnNeckEquipped");
				}
				else
				{
					evilBadStats.equipNeck = false;
					//evilBadStats.SendMessage("OnNeckUnEquipped");
					//evilBadStats.equippedNeck = null;

				}
			}
			else if(item.itemType == "Hands"){
				if(evilBadStats.isEquippedHands == false){
					GameObject handObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedHands = handObject;
					evilBadStats.equipHands = true;
					//evilBadStats.SendMessage ("OnHandsEquipped");
				}
				else
				{
					evilBadStats.equipHands = false;
					//evilBadStats.SendMessage("OnHandsUnEquipped");
					//evilBadStats.equippedHands = null;
				
				}
			}
			else if(item.itemType == "Head"){
				if(evilBadStats.isEquippedHead == false){
					GameObject headObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedHead = headObject;
					evilBadStats.equipHead = true;
					//evilBadStats.SendMessage ("OnHeadEquipped");
				}
				else
				{
					evilBadStats.equipHead = false;
					//evilBadStats.SendMessage("OnHeadUnEquipped");
					//evilBadStats.equippedHead = null;

				}
			}
			else if(item.itemType == "Ring1"){
				if(evilBadStats.isEquippedRing1 == false){
					GameObject ring1Object = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedRing1 = ring1Object;
					evilBadStats.equipRing1 = true;
					//evilBadStats.SendMessage ("OnRing1Equipped");
				}
				else
				{
					evilBadStats.equipRing1 = false;
					//evilBadStats.SendMessage("OnRing1UnEquipped");
					//evilBadStats.equippedRing1 = null;

				}
			}
			else if(item.itemType == "Ring2"){
				if(evilBadStats.isEquippedRing2 == false){
					GameObject ring2Object = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedRing2 = ring2Object;
					evilBadStats.equipRing2 = true;
					//evilBadStats.SendMessage ("OnRing2Equipped");
				}
				else
				{
					evilBadStats.equipRing2 = false;
					//evilBadStats.SendMessage("OnRing2UnEquipped");
					//evilBadStats.equippedRing2 = null;

				}
			}
			else if(item.itemType == "Feet"){
				if(evilBadStats.isEquippedFeet == false){
					GameObject feetObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedFeet = feetObject;
					evilBadStats.equipFeet = true;
					//evilBadStats.SendMessage ("OnFeetEquipped");
				}
				else
				{
					evilBadStats.equipFeet = false;
					//evilBadStats.SendMessage("OnFeetUnEquipped");
					//evilBadStats.equippedFeet = null;

				}
			}
			else if(item.itemType == "Waist"){
				if(evilBadStats.isEquippedWaste == false){
					GameObject waistObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedWaste = waistObject;

					evilBadStats.equipWaste = true;
					//evilBadStats.SendMessage ("OnWaistEquipped");
				}
				else
				{
					evilBadStats.equipWaste = false;
					//evilBadStats.SendMessage("OnWaistnUnEquipped");
					//evilBadStats.equippedWaste = null;

				}
			}
			else if(item.itemType == "Shield"){
				if(evilBadStats.isEquippedShield == false){
					GameObject shieldObject = Resources.Load <GameObject>(item.itemName);
					evilBadStats.equippedShield = shieldObject;
					evilBadStats.equipShield = true;
					//evilBadStats.SendMessage ("OnShieldEquipped");
				}
				else
				{
					evilBadStats.equipShield = false;
					//evilBadStats.SendMessage("OnShieldUnEquipped");
					//evilBadStats.equippedShield = null;

				}
			}
		}
    }

	public void OnPointerEnter(PointerEventData data)
    {
        if(inventory.Items[slotNumber].itemName != null && !inventory.draggingItem)
		{
			inventory.showTooltip(inventory.Slots[slotNumber].GetComponent<RectTransform>().localPosition, inventory.Items[slotNumber]);
		

		}


    }

	public void OnPointerStay(PointerEventData data)
	{

	}
	public void OnPointerExit(PointerEventData data)
	{
		if(inventory.Items[slotNumber].itemName != null)
		inventory.closeTooltip();
	}

   
}
