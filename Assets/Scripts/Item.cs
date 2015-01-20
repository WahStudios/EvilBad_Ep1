﻿using UnityEngine;
using System.Collections;

public class Item  {

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Sprite ItemIcon;
    public GameObject itemModel;
    public int itemPower;
    public int itemSpeed;
    public int itemValue;
    public ItemType itemType;

    public enum ItemType
    {
        Weapon,
        Consumable,
		Belt,
        Quest,
        Head,
        Feet,
        Chest,
        Trousers,
        Earrings,
        Neck,
        Rings,
        Hands,
		Shield
    }

    public Item(string name, int id, string desc, int power, int speed, int value, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemSpeed = speed;
        itemValue = value;
        itemType = type;
		ItemIcon = Resources.Load<Sprite>("" + name);
    }

    public Item()
    { }
}
