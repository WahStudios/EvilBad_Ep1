using UnityEngine;
using System.Collections;
//using System.IO;
public class ItemStats : MonoBehaviour {

	public string itemName;
	public ItemType itemType;
	public string itemDesc;
	//public Sprite ItemIcon;
	public float itemGemSlots;
	public float HP;
	public float CD;
	public float GPrate;
	public float fireBallDamageIncreased;
	public bool chainLightning;

	[SerializeField]string WeaponStats = "Weapon Attributes";
	public float increaseWrath;
	public float itemPower;

	public float itemSwingSpeed; 
	public float itemAttackSpeedIncrease; 
	public float itemArcRange;
	public float itemWidth;
	public float itemHeight;
	public float itemRadus;
	public float itemWeaponLengthRadiusIncrease;

	public float itemChargeIncrease;
	public float itemKnockback;
	public float itemforwardMomentum;
	public float itemMeleeCritChanceIncrease;
	public float increaseMeleeCritDamage;
	public float increaseMeleeSpeed;
	public float increaseMeleeMax;
	public float increaseMaxWeaponDamage;
	












	[SerializeField]string SelfStats = "Self Attributes";
	public float increaseAwe;
	public float itemHpRegain;
	public float itemHpRegainIncrease;
	public float itemMaxHpIncrease;
	public float itemIncreaseBaseMaxHp;
	public float itemMoveSpeedIncrease;
	public float increaseJumpHeight;

	[SerializeField]string SummonStats = "Summon Attributes";
	public float increaseMercy;
	public float increaseSummonMaxHP;
	public float increaseSummonMaxGP;
	public float increaseSummonedMindControl;

	[SerializeField]string GodStats = "God Attributes";
	public float increaseVengeance;
	public float increaseExodus;
	public float itemGpCostReduce;
	public float itemGpDamageIncrease;
	public float itemGpRegeneration;
	public float increaseGPCritBonusDamage;
	public float maxGPincrease;
	public float increaseGPresistance;
	public float increaseMaxGP;
	public float increaseGPcritDamage;
	public float increaseGPregeneration;

	[SerializeField]string DefenseStats = "Defense Attributes";
	public float itemDefense;
	public float itemDefenseIncrease;
	public float increaseArmorBonus;

	[SerializeField]string ResistanceStats = "Resistance Attributes";
	public float itemWaterResist;
	public float increaseBonusResistFire;
	public float increaseBonusResistShadow;
	public float increaseResistLight;
	public float increaseResistWater;
	public float increaseResistWind;
	public float resistFireDamage;
	public float resistWindDamage;
	public float increaseWindDamage;
	public float increaseEarthResistance;
	public float increaseResistFire;
	public float resistLight;
	public float resistBlind;
	public float resistMelted;
	public float resistPoision;
	public float resistSlow;
	public float resistFright;
	public float resistHeadache;
	public float resistBrainFart;
	public float resistArmCrushed;
	public float resistWeakened;
	public float resistBlasphemed;

	[SerializeField]string DebuffStats = "Debuff Attributes";
	public float itemDamagedLoweredPerSecond;
	public float itemDamagedIncresedPerSecond;

	public float decreaseArmCrushTimer;
	public float decreaseBlasphemedTimer;
	public float lowerStunTimer;
	public float lowerCurseDebuffSeconds;
	public float lowerMuffledDebuffSeconds;
	public float lowerBrainFartDebuffSeconds;
	public float lowerJumpHeight;


	//new

	//[SerializeField]string ItemIDMustBeUniqueNumber ="Unique Number";
	public int itemID;

	public GameObject itemModel;
	public string itemTypeString;
	// Use this for initialization

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

	void Start () {
	
	switch(itemType){
		case ItemType.Atom:
			itemTypeString = "Atom";
			break;
		case ItemType.Axe:
			itemTypeString = "Axe";
			break;
		case ItemType.Belt:
			itemTypeString = "Belt";
			break;
		case ItemType.Blade:
			itemTypeString = "Blade";
			break;
		case ItemType.Chest:
			itemTypeString = "Chest";
			break;
		case ItemType.Consumable:
			itemTypeString = "Consumable";
			break;
		case ItemType.Cross:
			itemTypeString = "Cross";
			break;
		case ItemType.Earrings:
			itemTypeString = "Earrings";
			break;
		case ItemType.Feet:
			itemTypeString = "Feet";
			break;
		case ItemType.Force:
			itemTypeString = "Force";
			break;
		case ItemType.Hands:
			itemTypeString = "Hands";
			break;
		case ItemType.Head:
			itemTypeString = "Head";
			break;
		case ItemType.Helmet:
			itemTypeString = "Helmet";
			break;
		case ItemType.Horn:
			itemTypeString = "Horn";
			break;
		case ItemType.Neck:
			itemTypeString = "Neck";
			break;
		case ItemType.Quest:
			itemTypeString = "Quest";
			break;
		case ItemType.Rings:
			itemTypeString = "Rings";
			break;
		case ItemType.Saw:
			itemTypeString = "Saw";
			break;
		case ItemType.Shield:
			itemTypeString = "Shield";
			break;
		case ItemType.Spear:
			itemTypeString = "Spear";
			break;
		case ItemType.Tome:
			itemTypeString = "Tome";
			break;
		case ItemType.Trousers:
			itemTypeString = "Trousers";
			break;
		case ItemType.Wand:
			itemTypeString = "Wand";
			break;
		case ItemType.Weapon:
			itemTypeString = "Weapon";
			break;
		}



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
