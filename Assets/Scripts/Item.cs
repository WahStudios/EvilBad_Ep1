using UnityEngine;
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
        Quest,
        Head,
        Shoes,
        Chest,
        Trousers,
        Earrings,
        Necklace,
        Rings,
        Hands
    }

    public Item(string name, int id, string desc, int power, int speed, int value, ItemType type, Sprite sprite)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemSpeed = speed;
        itemValue = value;
        itemType = type;
        ItemIcon = sprite;
    }

    public Item()
    { }
}
