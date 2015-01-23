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

    public Item(string name, int id, string desc, int width, int length, int damage, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = damage;
        itemSpeed = width;
        itemValue = length;
        itemType = type;
		ItemIcon = Resources.Load<Sprite>("" + name);
    }

    public Item()
    { }
}
