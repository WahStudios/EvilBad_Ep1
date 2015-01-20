using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();

    public Sprite item1;
    public Sprite item2;
    public Sprite item3;
    public Sprite item4;
	public Sprite item5;
    public Sprite item6;
    public Sprite item7;
    public Sprite item8;
    public Sprite item9;
    public Sprite item10;
    public Sprite item11;
    public Sprite item12;
    public Sprite item13;
	public Sprite item14;
	public Sprite item15;
	public Sprite item16;
	public Sprite item17;
	public Sprite item18;
	public Sprite item19;
	public Sprite item20;
	public Sprite item21;
	// Use this for initialization
	void Start () {
        

		items.Add(new Item("Belt_Cord", 0, "A nice belt", 10, 10, 23, Item.ItemType.Belt));
		items.Add(new Item("Chest_ChoirRobe", 1, "A very nice robe", 15, 10, 45, Item.ItemType.Chest));
		items.Add(new Item("Feet_Boots", 2, "A pair of boots", 05, 10, 101, Item.ItemType.Feet));
		items.Add(new Item("Hands_SoftMittens", 3, "Mittens to keep you warm", 10, 10, 1, Item.ItemType.Hands));
		items.Add(new Item("Head_Towel", 4, "A towel for your head", 10, 10, 1, Item.ItemType.Head));
		items.Add(new Item("Item_SmallBlueSoda", 5, "To quench your thirst", 10, 10, 1, Item.ItemType.Consumable));
		items.Add(new Item("Item_SmallRedSoda", 6, "Drink up", 10, 10, 1, Item.ItemType.Consumable));
		items.Add(new Item("Neck_Amulet1", 7, "Marvelous Jewlery", 10, 10, 1, Item.ItemType.Neck));
		items.Add(new Item("Neck_Amulet2", 8, "It's been in the family", 10, 10, 1, Item.ItemType.Neck));
		items.Add(new Item("QuestItem_GodKey", 9, "The Key of a God", 10, 10, 1, Item.ItemType.Quest));
		items.Add(new Item("Ring1", 10, "A nice ring", 10, 10, 1, Item.ItemType.Rings));
		items.Add(new Item("Ring2", 11, "A great ring", 10, 10, 1, Item.ItemType.Rings));
		items.Add(new Item("Shield_WoodenShield", 12, "To Protect you", 10, 10, 1, Item.ItemType.Shield));
		items.Add(new Item("Weapon_Spear1", 13, "A Spear", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Spear2", 14, "A nice spear", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Spear3", 15, "To Protect you", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Spear4", 16, "To Defeat your enemy", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Sword1", 17, "To avenge your brethren", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Sword2", 18, "To take your foes", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Sword3", 19, "A very nice sword", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Sword4", 20, "A rare sword", 10, 10, 1, Item.ItemType.Weapon));
		items.Add(new Item("Weapon_Sword5", 21, "A very rare sword", 10, 10, 1, Item.ItemType.Weapon));
	


       

	}
	
}
