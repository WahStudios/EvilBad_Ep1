using UnityEngine;
using System.Collections;

public class Item  {

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Sprite ItemIcon;
    public GameObject itemModel;
    public float itemPower;
    public float itemSpeed;
    public float itemValue;
    public string itemType;
	public float itemSwingSpeed; 
	public float itemChargeIncrease;
	public float itemRadus;
	public float itemKnockback;
	public float itemforwardMomentum;
	public float itemDamagedLoweredPerSecond;
	public float itemArcRange;
	public float itemDamagedIncresedPerSecond;
	public float itemHpRegain;
	public float itemDefense;
	public float itemWaterResist;
	public float itemGemSlots;
	public float itemMeleeCritChanceIncrease;
	public float itemWeaponLengthRadiusIncrease;
	public float itemHpRegainIncrease;
	public float itemDefenseIncrease;
	public float itemMaxHpIncrease;
	public float itemMoveSpeedIncrease;
	public float itemAttackSpeedIncrease; 
	public float itemGpCostReduce;
	public float itemGpDamageIncrease;
	public float itemGpRegeneration;
	public float itemIncreaseBaseMaxHp;

/*
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
		Shield,
		Blade,
		Axe, 
		Force,
		Atom,
		Spear,
		Saw,
		Wand,
		Horn,
		Tome,
		Cross,
		Helmet



    }
*/
    public Item(string name, int id, string desc, float width, float length, float damage, float swingSpeed, float chargeIncrease, 
	            float radius, float knockback, float forwardMomentum, float damagedLoweredPerSecond, float arcRange, float damagedIncresedPerSecond,
	            float hpRegain, float defense, float waterResist, float gemSlots, float meleeCritChanceIncrease, float weaponLengthRadiusIncrease,
	            float hpRegainIncrease, float defenseIncrease, float maxHpIncrease, float moveSpeedIncrease, float attackSpeedIncrease, 
	            float gpCostReduce, float gpDamageIncrease, float gpRegeneration, float increaseBaseMaxHp)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = damage;
        itemSpeed = width;
        itemValue = length;
        //itemType = type;
		itemSwingSpeed = swingSpeed; 
		itemChargeIncrease = chargeIncrease;
		itemRadus = radius;
		itemKnockback = knockback;
		itemforwardMomentum = forwardMomentum;
		itemDamagedLoweredPerSecond = damagedLoweredPerSecond;
		itemArcRange = arcRange;
		itemDamagedIncresedPerSecond = damagedIncresedPerSecond;
		itemHpRegain = hpRegain;
		itemDefense = defense;
		itemWaterResist = waterResist;
		itemGemSlots = gemSlots;
		itemMeleeCritChanceIncrease = meleeCritChanceIncrease;
		itemWeaponLengthRadiusIncrease = weaponLengthRadiusIncrease;
		itemHpRegainIncrease = hpRegainIncrease;
		itemDefenseIncrease = defenseIncrease;
		itemMaxHpIncrease = maxHpIncrease;
		itemMoveSpeedIncrease = moveSpeedIncrease;
		itemAttackSpeedIncrease = attackSpeedIncrease; 
		itemGpCostReduce = gpCostReduce;
		itemGpDamageIncrease = gpDamageIncrease;
		itemGpRegeneration = gpRegeneration;
		itemIncreaseBaseMaxHp = increaseBaseMaxHp;

		itemType = Resources.Load<GameObject>("" + name).GetComponent<ItemStats>().itemTypeString;
		ItemIcon = Resources.Load<GameObject>("" + name).GetComponent<SpriteRenderer>().sprite;
    }

    public Item()
    { }
    
}
