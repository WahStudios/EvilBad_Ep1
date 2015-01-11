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
        

        items.Add(new Item("ItemPlaceholder1", 0, "Description", 10, 10, 23, Item.ItemType.Chest));
        items.Add(new Item("ItemPlaceholder2", 1, "Description", 15, 10, 45, Item.ItemType.Chest));
        items.Add(new Item("ItemPlaceholder3", 2, "Description", 05, 10, 101, Item.ItemType.Consumable));
		items.Add(new Item("ItemPlaceholder1", 3, "Description", 10, 10, 1, Item.ItemType.Chest));

       

	}
	
}
