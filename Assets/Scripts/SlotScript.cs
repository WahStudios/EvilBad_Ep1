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
	public bool isEquipped = false;
	public bool isUnEquipped = true;
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

			if(isEquipped == false && isUnEquipped == true){

				if(slotNumber >= 25){ //change 25 to highest inventory number later
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

				isEquipped = true;
			}
			else if(isEquipped == true && isUnEquipped == true){


			}

        }
        else
        {
			isEquipped = false;
			isUnEquipped = true;
            itemImage.enabled = false;
        }





    }


	public void OnDrag(PointerEventData data)
	{
		if(inventory.Items[slotNumber].itemName != null)
		{
			inventory.showDraggedItem(inventory.Items[slotNumber], slotNumber);



			if(slotNumber >= 25){ //change 25 to highest inventory number later
				//Debug.Log (item.itemType);
				if(item.itemType == "Weapon"){
					if(evilBadStats.isEquippedWeapon == true){
						GameObject weaponObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedWeapon = weaponObject;
						evilBadStats.equipWeapon = false;
						//evilBadStats.SendMessage ("OnWeaponEquipped");
					}
					//else
					////{
					//	evilBadStats.equipWeapon = true;
					//}
					
				}
				else if(item.itemType == "Armor"){
					if(evilBadStats.isEquippedArmor == true){
						GameObject armorObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedArmor = armorObject;
						evilBadStats.equipArmor = false;
						
						//evilBadStats.SendMessage ("OnArmorEquipped");
					}
					
				}
				else if(item.itemType == "Neck"){
					if(evilBadStats.isEquippedNeck == true){
						GameObject neckObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedNeck = neckObject;
						evilBadStats.equipNeck = false;
						
						//evilBadStats.SendMessage ("OnNeckEquipped");
					}

				}
				else if(item.itemType == "Hands"){
					if(evilBadStats.isEquippedHands == true){
						GameObject handsObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedHands = handsObject;
						evilBadStats.equipHands = false;
						//evilBadStats.SendMessage ("OnHandsEquipped");
					}
					
				}
				else if(item.itemType == "Head"){
					if(evilBadStats.isEquippedHead == true){
						GameObject headObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedHead = headObject;
						evilBadStats.equipHead = false;
						//evilBadStats.SendMessage ("OnHeadEquipped");
					}
					
				}
				else if(item.itemType == "Ring1"){
					if(evilBadStats.isEquippedRing1 == true){
						GameObject ring1Object = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedRing1 = ring1Object;
						evilBadStats.equipRing1 = false;
						//evilBadStats.SendMessage ("OnRing1Equipped");
					}
					
				}
				else if(item.itemType == "Ring2"){
					if(evilBadStats.isEquippedRing2 == true){
						GameObject ring2Object = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedRing2 = ring2Object;
						evilBadStats.equipRing2 = false;
						//evilBadStats.SendMessage ("OnRing2Equipped");
					}
					
				}
				else if(item.itemType == "Feet"){
					if(evilBadStats.isEquippedFeet == true){
						GameObject feetObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedFeet = feetObject;
						evilBadStats.equipFeet = false;
						//evilBadStats.SendMessage ("OnFeetEquipped");
					}
					
				}
				else if(item.itemType == "Waist"){
					if(evilBadStats.isEquippedWaste == true){
						GameObject waistObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedWaste = waistObject;

						evilBadStats.equipWaste = false;
						//evilBadStats.SendMessage ("OnWaistEquipped");
						
					}
					else if(item.itemType == "Shield"){
						if(evilBadStats.isEquippedShield == true){
							GameObject shieldObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
							evilBadStats.equippedShield = shieldObject;
							evilBadStats.equipShield = false;
							//evilBadStats.SendMessage ("OnShieldEquipped");
						}
						
					}
				}
			}
			inventory.Items[slotNumber] = new Item();
		}
	}

	public void OnPointerDown(PointerEventData data)
    {
        

		if(inventory.Items[slotNumber].itemName == null && inventory.draggingItem)
		{
			if(slotNumber <25){
			inventory.Items[slotNumber] = inventory.draggedItem;
			inventory.closeDraggedItem();
			}
			else if(slotNumber == 30){
				if(inventory.draggedItem.itemType == "Weapon"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 26){
				if(inventory.draggedItem.itemType == "Armor"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 34){
				if(inventory.draggedItem.itemType == "Neck"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 27){
				if(inventory.draggedItem.itemType == "Hands"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 25){
				if(inventory.draggedItem.itemType == "Head"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 32){
				if(inventory.draggedItem.itemType == "Ring1"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 33){
				if(inventory.draggedItem.itemType == "Ring2"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 29){
				if(inventory.draggedItem.itemType == "Feet"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 28){
				if(inventory.draggedItem.itemType == "Waist"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber == 31){
				if(inventory.draggedItem.itemType == "Shield"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}

		}
		else if(inventory.draggingItem && inventory.Items[slotNumber].itemName != null)
		{
			if(slotNumber < 25){
				inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
				inventory.Items[slotNumber] = inventory.draggedItem;
				//isEquipped = false;
				inventory.closeDraggedItem();
			}
			else if(slotNumber == 30){ //weapon
				//Debug.Log (item.itemType);
				if(inventory.draggedItem.itemType == "Weapon"){
					if(evilBadStats.isEquippedWeapon == true){
						GameObject weaponObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedWeapon = weaponObject;
						evilBadStats.equipWeapon = false;
						//evilBadStats.SendMessage ("OnWeaponEquipped");
					}
					inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
					inventory.Items[slotNumber] = inventory.draggedItem;
					isEquipped = false;
					inventory.closeDraggedItem();

				}
			}else if(slotNumber == 26){ //chest
				if(inventory.draggedItem.itemType == "Armor"){
					if(evilBadStats.isEquippedArmor == true){
						
						GameObject armorObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedArmor = armorObject;
						evilBadStats.equipArmor = false;
						
						//evilBadStats.SendMessage ("OnArmorEquipped");
					}
					inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
					inventory.Items[slotNumber] = inventory.draggedItem;
					isEquipped = false;
					inventory.closeDraggedItem();
					
				}
			}
			else if(slotNumber == 34){ //neck
				if(inventory.draggedItem.itemType == "Neck"){
					if(evilBadStats.isEquippedNeck == true){
						GameObject neckObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedNeck = neckObject;
						evilBadStats.equipNeck = false;
						
						//evilBadStats.SendMessage ("OnNeckEquipped");
					}
					inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
					inventory.Items[slotNumber] = inventory.draggedItem;
					isEquipped = false;
					inventory.closeDraggedItem();
				}
			}
			else if(slotNumber == 27){ //hands
				if(inventory.draggedItem.itemType == "Hands"){
					if(evilBadStats.isEquippedHands == true){
						GameObject handsObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedHands = handsObject;
						evilBadStats.equipHands = false;
						//evilBadStats.SendMessage ("OnHandsEquipped");
					}
			}
			}
			else if (slotNumber == 25){ //head
				if(inventory.draggedItem.itemType == "Head"){
					if(evilBadStats.isEquippedHead == true){
						GameObject headObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedHead = headObject;
						evilBadStats.equipHead = false;
						//evilBadStats.SendMessage ("OnHeadEquipped");
					}
					
				}

			}
			else if (slotNumber == 32){ //ring1
				if(inventory.draggedItem.itemType == "Ring1"){
					if(evilBadStats.isEquippedRing1 == true){
						GameObject ring1Object = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedRing1 = ring1Object;
						evilBadStats.equipRing1 = false;
						//evilBadStats.SendMessage ("OnRing1Equipped");
					}
			}
			}
			else if(slotNumber == 33) //ring2
				{
					if(inventory.draggedItem.itemType == "Ring2"){
						if(evilBadStats.isEquippedRing2 == true){
							GameObject ring2Object = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
							evilBadStats.equippedRing2 = ring2Object;
							evilBadStats.equipRing2 = false;
							//evilBadStats.SendMessage ("OnRing2Equipped");
						}
				}
				}
				else if(slotNumber == 29){//feet
					if(inventory.draggedItem.itemType == "Feet"){
						if(evilBadStats.isEquippedFeet == true){
							GameObject feetObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
							evilBadStats.equippedFeet = feetObject;
							evilBadStats.equipFeet = false;
							//evilBadStats.SendMessage ("OnFeetEquipped");
						}
				}
					
				}

				else if(slotNumber == 28){
				if(inventory.draggedItem.itemType == "Waist"){
					if(evilBadStats.isEquippedWaste == true){
						GameObject waistObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedWaste = waistObject;
						
						evilBadStats.equipWaste = false;
						//evilBadStats.SendMessage ("OnWaistEquipped");
						
					}
				}
			}

			else if(slotNumber == 31){//shield
			
				if(inventory.draggedItem.itemType == "Shield"){
					if(evilBadStats.isEquippedShield == true){
						GameObject shieldObject = Resources.Load <GameObject>(inventory.Items[slotNumber].itemName);
						evilBadStats.equippedShield = shieldObject;
						evilBadStats.equipShield = false;
						//evilBadStats.SendMessage ("OnShieldEquipped");
					}
				}

			}
		}
	}


			





			
			//isEquipped = true;
		//}
			//Debug.Log ("dragging");
		

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
		if(inventory.Items[slotNumber].itemName != null){
		inventory.closeTooltip();

		}
	}

   
}
