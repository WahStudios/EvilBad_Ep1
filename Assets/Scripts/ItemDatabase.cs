using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();

    public Sprite item1;
    public Sprite item2;
    public Sprite item3;
    public Sprite item4;
    //public Sprite item5;
    //public Sprite item6;
    //public Sprite item7;
    //public Sprite item8;
    //public Sprite item9;
    //public Sprite item10;
    //public Sprite item11;
    //public Sprite item12;
    //public Sprite item13;
	// Use this for initialization
	void Start () {
        

        items.Add(new Item("ItemTile_Spear1", 0, "Nice Armor", 10, 10, 1, Item.ItemType.Chest, item1));
        items.Add(new Item("ItemTile_Sword1", 1, "Better Armor", 10, 10, 1, Item.ItemType.Chest, item2));
        items.Add(new Item("ItemTile_WoodenShield", 2, "NiceConsumable", 10, 10, 1, Item.ItemType.Consumable, item3));
       

	}
	
}
