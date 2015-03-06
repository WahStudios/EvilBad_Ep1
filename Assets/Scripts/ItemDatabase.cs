using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();

    public GameObject item1;
	ItemStats itemStats1;
	public GameObject item2;
	 ItemStats itemStats2;
    public GameObject item3;
	 ItemStats itemStats3;
    public GameObject item4;
	 ItemStats itemStats4;
	public GameObject item5;
	 ItemStats itemStats5;
    public GameObject item6;
 ItemStats itemStats6;
    public GameObject item7;
	 ItemStats itemStats7;
    public GameObject item8;
	 ItemStats itemStats8;
    public GameObject item9;
	 ItemStats itemStats9;
    public GameObject item10;
	 ItemStats itemStats10;
    public GameObject item11;
	ItemStats itemStats11;
    public GameObject item12;
	 ItemStats itemStats12;
    public GameObject item13;
	 ItemStats itemStats13;
	public GameObject item14;
	 ItemStats itemStats14;
	public GameObject item15;
	 ItemStats itemStats15;
	public GameObject item16;
	 ItemStats itemStats16;
	public GameObject item17;
	 ItemStats itemStats17;
	public GameObject item18;
	 ItemStats itemStats18;
	public GameObject item19;
	 ItemStats itemStats19;
	public GameObject item20;
	 ItemStats itemStats20;
	public GameObject item21;
	 ItemStats itemStats21;
	public GameObject item22;
	ItemStats itemStats22;
	public GameObject item23;
	 ItemStats itemStats23;
	public GameObject item24;
	ItemStats itemStats24;
	public GameObject item25;
	ItemStats itemStats25;
	public GameObject item26;
	ItemStats itemStats26;
	public GameObject item27;
	ItemStats itemStats27;
	public GameObject item28;
	ItemStats itemStats28;
	public GameObject item29;
	ItemStats itemStats29;
	public GameObject item30;
	ItemStats itemStats30;
	public GameObject item31;
	ItemStats itemStats31;
	public GameObject item32;
	ItemStats itemStats32;
	public GameObject item33;
	ItemStats itemStats33;
	public GameObject item34;
	ItemStats itemStats34;
	public GameObject item35;
	ItemStats itemStats35;
	public GameObject item36;
	ItemStats itemStats36;
	public GameObject item37;
	ItemStats itemStats37;
	public GameObject item38;
	ItemStats itemStats38;
	public GameObject item39;
	ItemStats itemStats39;
	public GameObject item40;
	ItemStats itemStats40;
	public GameObject item41;
	ItemStats itemStats41;
	public GameObject item42;
	ItemStats itemStats42;
	public GameObject item43;
	ItemStats itemStats43;
	public GameObject item44;
	ItemStats itemStats44;
	public GameObject item45;
	ItemStats itemStats45;
	public GameObject item46;
	ItemStats itemStats46;
	public GameObject item47;
	ItemStats itemStats47;
	public GameObject item48;
	ItemStats itemStats48;
	public GameObject item49;
	ItemStats itemStats49;
	/*
	public GameObject item25;
	ItemStats itemStats25;
	public GameObject item26;
	ItemStats itemStats26;
	public GameObject item27;
	ItemStats itemStats27;
	public GameObject item28;
	ItemStats itemStats28;
	public GameObject item29;
	ItemStats itemStats29;
	public GameObject item30;

ItemStats itemStats30;
*/
	//public GameObject item25;
	//ItemStats itemStats25;
	// Use this for initializati

	void Start () {
		itemStats1 = item1.GetComponent<ItemStats>();
		itemStats2 = item2.GetComponent<ItemStats>();
		itemStats3 = item3.GetComponent<ItemStats>();
		itemStats4 = item4.GetComponent<ItemStats>();
		itemStats5 = item5.GetComponent<ItemStats>();
		itemStats6 = item6.GetComponent<ItemStats>();
		itemStats7 = item7.GetComponent<ItemStats>();
		itemStats8 = item8.GetComponent<ItemStats>();
		itemStats9 = item9.GetComponent<ItemStats>();
		itemStats10 = item10.GetComponent<ItemStats>();
		itemStats11 = item11.GetComponent<ItemStats>();
		itemStats12 = item12.GetComponent<ItemStats>();
		itemStats13 = item13.GetComponent<ItemStats>();
		itemStats14 = item14.GetComponent<ItemStats>();
		itemStats15 = item15.GetComponent<ItemStats>();
		itemStats16 = item16.GetComponent<ItemStats>();
		itemStats17 = item17.GetComponent<ItemStats>();
		itemStats18 = item18.GetComponent<ItemStats>();
		itemStats19 = item19.GetComponent<ItemStats>();
		itemStats20 = item20.GetComponent<ItemStats>();
		itemStats21 = item21.GetComponent<ItemStats>();
		itemStats22 = item22.GetComponent<ItemStats>();
		itemStats23 = item23.GetComponent<ItemStats>();
		itemStats24 = item24.GetComponent<ItemStats>();
		itemStats25 = item25.GetComponent<ItemStats>();
		itemStats26 = item26.GetComponent<ItemStats>();
		itemStats27 = item27.GetComponent<ItemStats>();
		itemStats28 = item28.GetComponent<ItemStats>();
		itemStats29 = item29.GetComponent<ItemStats>();
		itemStats30 = item30.GetComponent<ItemStats>();
		itemStats31 = item31.GetComponent<ItemStats>();
		itemStats32 = item32.GetComponent<ItemStats>();
		itemStats33 = item33.GetComponent<ItemStats>();
		itemStats34 = item34.GetComponent<ItemStats>();
		itemStats35 = item35.GetComponent<ItemStats>();
		itemStats36 = item36.GetComponent<ItemStats>();
		itemStats37 = item37.GetComponent<ItemStats>();
		itemStats38 = item38.GetComponent<ItemStats>();
		itemStats39 = item39.GetComponent<ItemStats>();
		itemStats40 = item40.GetComponent<ItemStats>();
		itemStats41 = item41.GetComponent<ItemStats>();
		itemStats42 = item42.GetComponent<ItemStats>();
		itemStats43 = item43.GetComponent<ItemStats>();
		itemStats44 = item44.GetComponent<ItemStats>();
		itemStats45 = item45.GetComponent<ItemStats>();
		itemStats46 = item46.GetComponent<ItemStats>();
		itemStats47 = item47.GetComponent<ItemStats>();
		itemStats48 = item48.GetComponent<ItemStats>();
		itemStats49 = item49.GetComponent<ItemStats>();
		/*
		itemStats25 = item25.GetComponent<ItemStats>();
		itemStats26 = item26.GetComponent<ItemStats>();
		itemStats27 = item27.GetComponent<ItemStats>();
		itemStats28 = item28.GetComponent<ItemStats>();
		itemStats29 = item29.GetComponent<ItemStats>();
		itemStats30 = item30.GetComponent<ItemStats>();
*/

	
        
		
		items.Add(new Item(item1.name, itemStats1.itemID, itemStats1.itemDesc, itemStats1.itemWidth, itemStats1.itemHeight, itemStats1.itemPower, itemStats1.itemSwingSpeed,itemStats1.itemChargeIncrease,
		                   itemStats1.itemRadus, itemStats1.itemKnockback, itemStats1.itemforwardMomentum, itemStats1.itemDamagedLoweredPerSecond,itemStats1.itemArcRange,itemStats1.itemDamagedIncresedPerSecond,
		                   itemStats1.itemHpRegain,itemStats1.itemDefense,itemStats1.itemWaterResist,itemStats1.itemGemSlots,itemStats1.itemMeleeCritChanceIncrease,itemStats1.itemWeaponLengthRadiusIncrease,
		                   itemStats1.itemHpRegainIncrease,itemStats1.itemDefenseIncrease,itemStats1.itemMaxHpIncrease,itemStats1.itemMoveSpeedIncrease,itemStats1.itemAttackSpeedIncrease,
		                   itemStats1.itemGpCostReduce,itemStats1.itemGpDamageIncrease,itemStats1.itemGpRegeneration, itemStats1.itemIncreaseBaseMaxHp, itemStats1.itemTypeString));
	
		items.Add(new Item(item2.name, itemStats2.itemID, itemStats2.itemDesc, itemStats2.itemWidth, itemStats2.itemHeight, itemStats2.itemPower, itemStats2.itemSwingSpeed,itemStats2.itemChargeIncrease,
		                   itemStats2.itemRadus, itemStats2.itemKnockback, itemStats2.itemforwardMomentum, itemStats2.itemDamagedLoweredPerSecond,itemStats2.itemArcRange,itemStats2.itemDamagedIncresedPerSecond,
		                   itemStats2.itemHpRegain,itemStats2.itemDefense,itemStats2.itemWaterResist,itemStats2.itemGemSlots,itemStats2.itemMeleeCritChanceIncrease,itemStats2.itemWeaponLengthRadiusIncrease,
		                   itemStats2.itemHpRegainIncrease,itemStats2.itemDefenseIncrease,itemStats2.itemMaxHpIncrease,itemStats2.itemMoveSpeedIncrease,itemStats2.itemAttackSpeedIncrease,
		                   itemStats2.itemGpCostReduce,itemStats2.itemGpDamageIncrease,itemStats2.itemGpRegeneration, itemStats2.itemIncreaseBaseMaxHp, itemStats2.itemTypeString));

		items.Add(new Item(item3.name, itemStats3.itemID, itemStats3.itemDesc, itemStats3.itemWidth, itemStats3.itemHeight, itemStats3.itemPower, itemStats3.itemSwingSpeed,itemStats3.itemChargeIncrease,
		                   itemStats3.itemRadus, itemStats3.itemKnockback, itemStats3.itemforwardMomentum, itemStats3.itemDamagedLoweredPerSecond,itemStats3.itemArcRange,itemStats3.itemDamagedIncresedPerSecond,
		                   itemStats3.itemHpRegain,itemStats3.itemDefense,itemStats3.itemWaterResist,itemStats3.itemGemSlots,itemStats3.itemMeleeCritChanceIncrease,itemStats3.itemWeaponLengthRadiusIncrease,
		                   itemStats3.itemHpRegainIncrease,itemStats3.itemDefenseIncrease,itemStats3.itemMaxHpIncrease,itemStats3.itemMoveSpeedIncrease,itemStats3.itemAttackSpeedIncrease,
		                   itemStats3.itemGpCostReduce,itemStats3.itemGpDamageIncrease,itemStats3.itemGpRegeneration, itemStats3.itemIncreaseBaseMaxHp, itemStats3.itemTypeString));

		items.Add(new Item(item4.name, itemStats4.itemID, itemStats4.itemDesc, itemStats4.itemWidth, itemStats4.itemHeight, itemStats4.itemPower, itemStats4.itemSwingSpeed,itemStats4.itemChargeIncrease,
		                   itemStats4.itemRadus, itemStats4.itemKnockback, itemStats4.itemforwardMomentum, itemStats4.itemDamagedLoweredPerSecond,itemStats4.itemArcRange,itemStats4.itemDamagedIncresedPerSecond,
		                   itemStats4.itemHpRegain,itemStats4.itemDefense,itemStats4.itemWaterResist,itemStats4.itemGemSlots,itemStats4.itemMeleeCritChanceIncrease,itemStats4.itemWeaponLengthRadiusIncrease,
		                   itemStats4.itemHpRegainIncrease,itemStats4.itemDefenseIncrease,itemStats4.itemMaxHpIncrease,itemStats4.itemMoveSpeedIncrease,itemStats4.itemAttackSpeedIncrease,
		                   itemStats4.itemGpCostReduce,itemStats4.itemGpDamageIncrease,itemStats4.itemGpRegeneration, itemStats4.itemIncreaseBaseMaxHp, itemStats4.itemTypeString));

		items.Add(new Item(item5.name, itemStats5.itemID, itemStats5.itemDesc, itemStats5.itemWidth, itemStats5.itemHeight, itemStats5.itemPower, itemStats5.itemSwingSpeed,itemStats5.itemChargeIncrease,
		                   itemStats5.itemRadus, itemStats5.itemKnockback, itemStats5.itemforwardMomentum, itemStats5.itemDamagedLoweredPerSecond,itemStats5.itemArcRange,itemStats5.itemDamagedIncresedPerSecond,
		                   itemStats5.itemHpRegain,itemStats5.itemDefense,itemStats5.itemWaterResist,itemStats5.itemGemSlots,itemStats5.itemMeleeCritChanceIncrease,itemStats5.itemWeaponLengthRadiusIncrease,
		                   itemStats5.itemHpRegainIncrease,itemStats5.itemDefenseIncrease,itemStats5.itemMaxHpIncrease,itemStats5.itemMoveSpeedIncrease,itemStats5.itemAttackSpeedIncrease,
		                   itemStats5.itemGpCostReduce,itemStats5.itemGpDamageIncrease,itemStats5.itemGpRegeneration, itemStats5.itemIncreaseBaseMaxHp, itemStats5.itemTypeString));

		items.Add(new Item(item6.name, itemStats6.itemID, itemStats6.itemDesc, itemStats6.itemWidth, itemStats6.itemHeight, itemStats6.itemPower, itemStats6.itemSwingSpeed,itemStats6.itemChargeIncrease,
		                   itemStats6.itemRadus, itemStats6.itemKnockback, itemStats6.itemforwardMomentum, itemStats6.itemDamagedLoweredPerSecond,itemStats6.itemArcRange,itemStats6.itemDamagedIncresedPerSecond,
		                   itemStats6.itemHpRegain,itemStats6.itemDefense,itemStats6.itemWaterResist,itemStats6.itemGemSlots,itemStats6.itemMeleeCritChanceIncrease,itemStats6.itemWeaponLengthRadiusIncrease,
		                   itemStats6.itemHpRegainIncrease,itemStats6.itemDefenseIncrease,itemStats6.itemMaxHpIncrease,itemStats6.itemMoveSpeedIncrease,itemStats6.itemAttackSpeedIncrease,
		                   itemStats6.itemGpCostReduce,itemStats6.itemGpDamageIncrease,itemStats6.itemGpRegeneration, itemStats6.itemIncreaseBaseMaxHp, itemStats6.itemTypeString));


		items.Add(new Item(item7.name, itemStats7.itemID, itemStats7.itemDesc, itemStats7.itemWidth, itemStats7.itemHeight, itemStats7.itemPower, itemStats7.itemSwingSpeed,itemStats7.itemChargeIncrease,
		                   itemStats7.itemRadus, itemStats7.itemKnockback, itemStats7.itemforwardMomentum, itemStats7.itemDamagedLoweredPerSecond,itemStats7.itemArcRange,itemStats7.itemDamagedIncresedPerSecond,
		                   itemStats7.itemHpRegain,itemStats7.itemDefense,itemStats7.itemWaterResist,itemStats7.itemGemSlots,itemStats7.itemMeleeCritChanceIncrease,itemStats7.itemWeaponLengthRadiusIncrease,
		                   itemStats7.itemHpRegainIncrease,itemStats7.itemDefenseIncrease,itemStats7.itemMaxHpIncrease,itemStats7.itemMoveSpeedIncrease,itemStats7.itemAttackSpeedIncrease,
		                   itemStats7.itemGpCostReduce,itemStats7.itemGpDamageIncrease,itemStats7.itemGpRegeneration, itemStats7.itemIncreaseBaseMaxHp, itemStats7.itemTypeString));

		items.Add(new Item(item8.name, itemStats8.itemID, itemStats8.itemDesc, itemStats8.itemWidth, itemStats8.itemHeight, itemStats8.itemPower, itemStats8.itemSwingSpeed,itemStats8.itemChargeIncrease,
		                   itemStats8.itemRadus, itemStats8.itemKnockback, itemStats8.itemforwardMomentum, itemStats8.itemDamagedLoweredPerSecond,itemStats8.itemArcRange,itemStats8.itemDamagedIncresedPerSecond,
		                   itemStats8.itemHpRegain,itemStats8.itemDefense,itemStats8.itemWaterResist,itemStats8.itemGemSlots,itemStats8.itemMeleeCritChanceIncrease,itemStats8.itemWeaponLengthRadiusIncrease,
		                   itemStats8.itemHpRegainIncrease,itemStats8.itemDefenseIncrease,itemStats8.itemMaxHpIncrease,itemStats8.itemMoveSpeedIncrease,itemStats8.itemAttackSpeedIncrease,
		                   itemStats8.itemGpCostReduce,itemStats8.itemGpDamageIncrease,itemStats8.itemGpRegeneration, itemStats8.itemIncreaseBaseMaxHp, itemStats8.itemTypeString));

		items.Add(new Item(item9.name, itemStats9.itemID, itemStats9.itemDesc, itemStats9.itemWidth, itemStats9.itemHeight, itemStats9.itemPower, itemStats9.itemSwingSpeed,itemStats9.itemChargeIncrease,
		                   itemStats9.itemRadus, itemStats9.itemKnockback, itemStats9.itemforwardMomentum, itemStats9.itemDamagedLoweredPerSecond,itemStats9.itemArcRange,itemStats9.itemDamagedIncresedPerSecond,
		                   itemStats9.itemHpRegain,itemStats9.itemDefense,itemStats9.itemWaterResist,itemStats9.itemGemSlots,itemStats9.itemMeleeCritChanceIncrease,itemStats9.itemWeaponLengthRadiusIncrease,
		                   itemStats9.itemHpRegainIncrease,itemStats9.itemDefenseIncrease,itemStats9.itemMaxHpIncrease,itemStats9.itemMoveSpeedIncrease,itemStats9.itemAttackSpeedIncrease,
		                   itemStats9.itemGpCostReduce,itemStats9.itemGpDamageIncrease,itemStats9.itemGpRegeneration, itemStats9.itemIncreaseBaseMaxHp, itemStats9.itemTypeString));

		items.Add(new Item(item10.name, itemStats10.itemID, itemStats10.itemDesc, itemStats10.itemWidth, itemStats10.itemHeight, itemStats10.itemPower, itemStats10.itemSwingSpeed,itemStats10.itemChargeIncrease,
		                   itemStats10.itemRadus, itemStats10.itemKnockback, itemStats10.itemforwardMomentum, itemStats10.itemDamagedLoweredPerSecond,itemStats10.itemArcRange,itemStats10.itemDamagedIncresedPerSecond,
		                   itemStats10.itemHpRegain,itemStats10.itemDefense,itemStats10.itemWaterResist,itemStats10.itemGemSlots,itemStats10.itemMeleeCritChanceIncrease,itemStats10.itemWeaponLengthRadiusIncrease,
		                   itemStats10.itemHpRegainIncrease,itemStats10.itemDefenseIncrease,itemStats10.itemMaxHpIncrease,itemStats10.itemMoveSpeedIncrease,itemStats10.itemAttackSpeedIncrease,
		                   itemStats10.itemGpCostReduce,itemStats10.itemGpDamageIncrease,itemStats10.itemGpRegeneration, itemStats10.itemIncreaseBaseMaxHp, itemStats10.itemTypeString));

		items.Add(new Item(item11.name, itemStats11.itemID, itemStats11.itemDesc, itemStats11.itemWidth, itemStats11.itemHeight, itemStats11.itemPower, itemStats11.itemSwingSpeed,itemStats11.itemChargeIncrease,
		                   itemStats11.itemRadus, itemStats11.itemKnockback, itemStats11.itemforwardMomentum, itemStats11.itemDamagedLoweredPerSecond,itemStats11.itemArcRange,itemStats11.itemDamagedIncresedPerSecond,
		                   itemStats11.itemHpRegain,itemStats11.itemDefense,itemStats11.itemWaterResist,itemStats11.itemGemSlots,itemStats11.itemMeleeCritChanceIncrease,itemStats11.itemWeaponLengthRadiusIncrease,
		                   itemStats11.itemHpRegainIncrease,itemStats11.itemDefenseIncrease,itemStats11.itemMaxHpIncrease,itemStats11.itemMoveSpeedIncrease,itemStats11.itemAttackSpeedIncrease,
		                   itemStats11.itemGpCostReduce,itemStats11.itemGpDamageIncrease,itemStats11.itemGpRegeneration, itemStats11.itemIncreaseBaseMaxHp, itemStats11.itemTypeString));

		items.Add(new Item(item12.name, itemStats12.itemID, itemStats12.itemDesc, itemStats12.itemWidth, itemStats12.itemHeight, itemStats12.itemPower, itemStats12.itemSwingSpeed,itemStats12.itemChargeIncrease,
		                   itemStats12.itemRadus, itemStats12.itemKnockback, itemStats12.itemforwardMomentum, itemStats12.itemDamagedLoweredPerSecond,itemStats12.itemArcRange,itemStats12.itemDamagedIncresedPerSecond,
		                   itemStats12.itemHpRegain,itemStats12.itemDefense,itemStats12.itemWaterResist,itemStats12.itemGemSlots,itemStats12.itemMeleeCritChanceIncrease,itemStats12.itemWeaponLengthRadiusIncrease,
		                   itemStats12.itemHpRegainIncrease,itemStats12.itemDefenseIncrease,itemStats12.itemMaxHpIncrease,itemStats12.itemMoveSpeedIncrease,itemStats12.itemAttackSpeedIncrease,
		                   itemStats12.itemGpCostReduce,itemStats12.itemGpDamageIncrease,itemStats12.itemGpRegeneration, itemStats12.itemIncreaseBaseMaxHp, itemStats12.itemTypeString));

		items.Add(new Item(item13.name, itemStats13.itemID, itemStats13.itemDesc, itemStats13.itemWidth, itemStats13.itemHeight, itemStats13.itemPower, itemStats13.itemSwingSpeed,itemStats13.itemChargeIncrease,
		                   itemStats13.itemRadus, itemStats13.itemKnockback, itemStats13.itemforwardMomentum, itemStats13.itemDamagedLoweredPerSecond,itemStats13.itemArcRange,itemStats13.itemDamagedIncresedPerSecond,
		                   itemStats13.itemHpRegain,itemStats13.itemDefense,itemStats13.itemWaterResist,itemStats13.itemGemSlots,itemStats13.itemMeleeCritChanceIncrease,itemStats13.itemWeaponLengthRadiusIncrease,
		                   itemStats13.itemHpRegainIncrease,itemStats13.itemDefenseIncrease,itemStats13.itemMaxHpIncrease,itemStats13.itemMoveSpeedIncrease,itemStats13.itemAttackSpeedIncrease,
		                   itemStats13.itemGpCostReduce,itemStats13.itemGpDamageIncrease,itemStats13.itemGpRegeneration, itemStats13.itemIncreaseBaseMaxHp, itemStats13.itemTypeString));

		items.Add(new Item(item14.name, itemStats14.itemID, itemStats14.itemDesc, itemStats14.itemWidth, itemStats14.itemHeight, itemStats14.itemPower, itemStats14.itemSwingSpeed,itemStats14.itemChargeIncrease,
		                   itemStats14.itemRadus, itemStats14.itemKnockback, itemStats14.itemforwardMomentum, itemStats14.itemDamagedLoweredPerSecond,itemStats14.itemArcRange,itemStats14.itemDamagedIncresedPerSecond,
		                   itemStats14.itemHpRegain,itemStats14.itemDefense,itemStats14.itemWaterResist,itemStats14.itemGemSlots,itemStats14.itemMeleeCritChanceIncrease,itemStats14.itemWeaponLengthRadiusIncrease,
		                   itemStats14.itemHpRegainIncrease,itemStats14.itemDefenseIncrease,itemStats14.itemMaxHpIncrease,itemStats14.itemMoveSpeedIncrease,itemStats14.itemAttackSpeedIncrease,
		                   itemStats14.itemGpCostReduce,itemStats14.itemGpDamageIncrease,itemStats14.itemGpRegeneration, itemStats14.itemIncreaseBaseMaxHp, itemStats14.itemTypeString));

		items.Add(new Item(item15.name, itemStats15.itemID, itemStats15.itemDesc, itemStats15.itemWidth, itemStats15.itemHeight, itemStats15.itemPower, itemStats15.itemSwingSpeed,itemStats15.itemChargeIncrease,
		                   itemStats15.itemRadus, itemStats15.itemKnockback, itemStats15.itemforwardMomentum, itemStats15.itemDamagedLoweredPerSecond,itemStats15.itemArcRange,itemStats15.itemDamagedIncresedPerSecond,
		                   itemStats15.itemHpRegain,itemStats15.itemDefense,itemStats15.itemWaterResist,itemStats15.itemGemSlots,itemStats15.itemMeleeCritChanceIncrease,itemStats15.itemWeaponLengthRadiusIncrease,
		                   itemStats15.itemHpRegainIncrease,itemStats15.itemDefenseIncrease,itemStats15.itemMaxHpIncrease,itemStats15.itemMoveSpeedIncrease,itemStats15.itemAttackSpeedIncrease,
		                   itemStats15.itemGpCostReduce,itemStats15.itemGpDamageIncrease,itemStats15.itemGpRegeneration, itemStats15.itemIncreaseBaseMaxHp, itemStats15.itemTypeString));

		items.Add(new Item(item16.name, itemStats16.itemID, itemStats16.itemDesc, itemStats16.itemWidth, itemStats16.itemHeight, itemStats16.itemPower, itemStats16.itemSwingSpeed,itemStats16.itemChargeIncrease,
		                   itemStats16.itemRadus, itemStats16.itemKnockback, itemStats16.itemforwardMomentum, itemStats16.itemDamagedLoweredPerSecond,itemStats16.itemArcRange,itemStats16.itemDamagedIncresedPerSecond,
		                   itemStats16.itemHpRegain,itemStats16.itemDefense,itemStats16.itemWaterResist,itemStats16.itemGemSlots,itemStats16.itemMeleeCritChanceIncrease,itemStats16.itemWeaponLengthRadiusIncrease,
		                   itemStats16.itemHpRegainIncrease,itemStats16.itemDefenseIncrease,itemStats16.itemMaxHpIncrease,itemStats16.itemMoveSpeedIncrease,itemStats16.itemAttackSpeedIncrease,
		                   itemStats16.itemGpCostReduce,itemStats16.itemGpDamageIncrease,itemStats16.itemGpRegeneration, itemStats16.itemIncreaseBaseMaxHp, itemStats16.itemTypeString));

		items.Add(new Item(item17.name, itemStats17.itemID, itemStats17.itemDesc, itemStats17.itemWidth, itemStats17.itemHeight, itemStats17.itemPower, itemStats17.itemSwingSpeed,itemStats17.itemChargeIncrease,
		                   itemStats17.itemRadus, itemStats17.itemKnockback, itemStats17.itemforwardMomentum, itemStats17.itemDamagedLoweredPerSecond,itemStats17.itemArcRange,itemStats17.itemDamagedIncresedPerSecond,
		                   itemStats17.itemHpRegain,itemStats17.itemDefense,itemStats17.itemWaterResist,itemStats17.itemGemSlots,itemStats17.itemMeleeCritChanceIncrease,itemStats17.itemWeaponLengthRadiusIncrease,
		                   itemStats17.itemHpRegainIncrease,itemStats17.itemDefenseIncrease,itemStats17.itemMaxHpIncrease,itemStats17.itemMoveSpeedIncrease,itemStats17.itemAttackSpeedIncrease,
		                   itemStats17.itemGpCostReduce,itemStats17.itemGpDamageIncrease,itemStats17.itemGpRegeneration, itemStats17.itemIncreaseBaseMaxHp, itemStats17.itemTypeString));

		items.Add(new Item(item18.name, itemStats18.itemID, itemStats18.itemDesc, itemStats18.itemWidth, itemStats18.itemHeight, itemStats18.itemPower, itemStats18.itemSwingSpeed,itemStats18.itemChargeIncrease,
		                   itemStats18.itemRadus, itemStats18.itemKnockback, itemStats18.itemforwardMomentum, itemStats18.itemDamagedLoweredPerSecond,itemStats18.itemArcRange,itemStats18.itemDamagedIncresedPerSecond,
		                   itemStats18.itemHpRegain,itemStats18.itemDefense,itemStats18.itemWaterResist,itemStats18.itemGemSlots,itemStats18.itemMeleeCritChanceIncrease,itemStats18.itemWeaponLengthRadiusIncrease,
		                   itemStats18.itemHpRegainIncrease,itemStats18.itemDefenseIncrease,itemStats18.itemMaxHpIncrease,itemStats18.itemMoveSpeedIncrease,itemStats18.itemAttackSpeedIncrease,
		                   itemStats18.itemGpCostReduce,itemStats18.itemGpDamageIncrease,itemStats18.itemGpRegeneration, itemStats18.itemIncreaseBaseMaxHp, itemStats18.itemTypeString));

		items.Add(new Item(item19.name, itemStats19.itemID, itemStats19.itemDesc, itemStats19.itemWidth, itemStats19.itemHeight, itemStats19.itemPower, itemStats19.itemSwingSpeed,itemStats19.itemChargeIncrease,
		                   itemStats19.itemRadus, itemStats19.itemKnockback, itemStats19.itemforwardMomentum, itemStats19.itemDamagedLoweredPerSecond,itemStats19.itemArcRange,itemStats19.itemDamagedIncresedPerSecond,
		                   itemStats19.itemHpRegain,itemStats19.itemDefense,itemStats19.itemWaterResist,itemStats19.itemGemSlots,itemStats19.itemMeleeCritChanceIncrease,itemStats19.itemWeaponLengthRadiusIncrease,
		                   itemStats19.itemHpRegainIncrease,itemStats19.itemDefenseIncrease,itemStats19.itemMaxHpIncrease,itemStats19.itemMoveSpeedIncrease,itemStats19.itemAttackSpeedIncrease,
		                   itemStats19.itemGpCostReduce,itemStats19.itemGpDamageIncrease,itemStats19.itemGpRegeneration, itemStats19.itemIncreaseBaseMaxHp, itemStats19.itemTypeString));

		items.Add(new Item(item20.name, itemStats20.itemID, itemStats20.itemDesc, itemStats20.itemWidth, itemStats20.itemHeight, itemStats20.itemPower, itemStats20.itemSwingSpeed,itemStats20.itemChargeIncrease,
		                   itemStats20.itemRadus, itemStats20.itemKnockback, itemStats20.itemforwardMomentum, itemStats20.itemDamagedLoweredPerSecond,itemStats20.itemArcRange,itemStats20.itemDamagedIncresedPerSecond,
		                   itemStats20.itemHpRegain,itemStats20.itemDefense,itemStats20.itemWaterResist,itemStats20.itemGemSlots,itemStats20.itemMeleeCritChanceIncrease,itemStats20.itemWeaponLengthRadiusIncrease,
		                   itemStats20.itemHpRegainIncrease,itemStats20.itemDefenseIncrease,itemStats20.itemMaxHpIncrease,itemStats20.itemMoveSpeedIncrease,itemStats20.itemAttackSpeedIncrease,
		                   itemStats20.itemGpCostReduce,itemStats20.itemGpDamageIncrease,itemStats20.itemGpRegeneration, itemStats20.itemIncreaseBaseMaxHp, itemStats20.itemTypeString));

		items.Add(new Item(item21.name, itemStats21.itemID, itemStats21.itemDesc, itemStats21.itemWidth, itemStats21.itemHeight, itemStats21.itemPower, itemStats21.itemSwingSpeed,itemStats21.itemChargeIncrease,
		                   itemStats21.itemRadus, itemStats21.itemKnockback, itemStats21.itemforwardMomentum, itemStats21.itemDamagedLoweredPerSecond,itemStats21.itemArcRange,itemStats21.itemDamagedIncresedPerSecond,
		                   itemStats21.itemHpRegain,itemStats21.itemDefense,itemStats21.itemWaterResist,itemStats21.itemGemSlots,itemStats21.itemMeleeCritChanceIncrease,itemStats21.itemWeaponLengthRadiusIncrease,
		                   itemStats21.itemHpRegainIncrease,itemStats21.itemDefenseIncrease,itemStats21.itemMaxHpIncrease,itemStats21.itemMoveSpeedIncrease,itemStats21.itemAttackSpeedIncrease,
		                   itemStats21.itemGpCostReduce,itemStats21.itemGpDamageIncrease,itemStats21.itemGpRegeneration, itemStats21.itemIncreaseBaseMaxHp, itemStats21.itemTypeString));

		items.Add(new Item(item22.name, itemStats22.itemID, itemStats22.itemDesc, itemStats22.itemWidth, itemStats22.itemHeight, itemStats22.itemPower, itemStats22.itemSwingSpeed,itemStats22.itemChargeIncrease,
		                   itemStats22.itemRadus, itemStats22.itemKnockback, itemStats22.itemforwardMomentum, itemStats22.itemDamagedLoweredPerSecond,itemStats22.itemArcRange,itemStats22.itemDamagedIncresedPerSecond,
		                   itemStats22.itemHpRegain,itemStats22.itemDefense,itemStats22.itemWaterResist,itemStats22.itemGemSlots,itemStats22.itemMeleeCritChanceIncrease,itemStats22.itemWeaponLengthRadiusIncrease,
		                   itemStats22.itemHpRegainIncrease,itemStats22.itemDefenseIncrease,itemStats22.itemMaxHpIncrease,itemStats22.itemMoveSpeedIncrease,itemStats22.itemAttackSpeedIncrease,
		                   itemStats22.itemGpCostReduce,itemStats22.itemGpDamageIncrease,itemStats22.itemGpRegeneration, itemStats22.itemIncreaseBaseMaxHp, itemStats22.itemTypeString));

		items.Add(new Item(item23.name, itemStats23.itemID, itemStats23.itemDesc, itemStats23.itemWidth, itemStats23.itemHeight, itemStats23.itemPower, itemStats23.itemSwingSpeed,itemStats23.itemChargeIncrease,
		                   itemStats23.itemRadus, itemStats23.itemKnockback, itemStats23.itemforwardMomentum, itemStats23.itemDamagedLoweredPerSecond,itemStats23.itemArcRange,itemStats23.itemDamagedIncresedPerSecond,
		                   itemStats23.itemHpRegain,itemStats23.itemDefense,itemStats23.itemWaterResist,itemStats23.itemGemSlots,itemStats23.itemMeleeCritChanceIncrease,itemStats23.itemWeaponLengthRadiusIncrease,
		                   itemStats23.itemHpRegainIncrease,itemStats23.itemDefenseIncrease,itemStats23.itemMaxHpIncrease,itemStats23.itemMoveSpeedIncrease,itemStats23.itemAttackSpeedIncrease,
		                   itemStats23.itemGpCostReduce,itemStats23.itemGpDamageIncrease,itemStats23.itemGpRegeneration, itemStats23.itemIncreaseBaseMaxHp, itemStats23.itemTypeString));

		items.Add(new Item(item24.name, itemStats24.itemID, itemStats24.itemDesc, itemStats24.itemWidth, itemStats24.itemHeight, itemStats24.itemPower, itemStats24.itemSwingSpeed,itemStats24.itemChargeIncrease,
		                   itemStats24.itemRadus, itemStats24.itemKnockback, itemStats24.itemforwardMomentum, itemStats24.itemDamagedLoweredPerSecond,itemStats24.itemArcRange,itemStats24.itemDamagedIncresedPerSecond,
		                   itemStats24.itemHpRegain,itemStats24.itemDefense,itemStats24.itemWaterResist,itemStats24.itemGemSlots,itemStats24.itemMeleeCritChanceIncrease,itemStats24.itemWeaponLengthRadiusIncrease,
		                   itemStats24.itemHpRegainIncrease,itemStats24.itemDefenseIncrease,itemStats24.itemMaxHpIncrease,itemStats24.itemMoveSpeedIncrease,itemStats24.itemAttackSpeedIncrease,
		                   itemStats24.itemGpCostReduce,itemStats24.itemGpDamageIncrease,itemStats24.itemGpRegeneration, itemStats24.itemIncreaseBaseMaxHp, itemStats24.itemTypeString));

		items.Add(new Item(item25.name, itemStats25.itemID, itemStats25.itemDesc, itemStats25.itemWidth, itemStats25.itemHeight, itemStats25.itemPower, itemStats25.itemSwingSpeed,itemStats25.itemChargeIncrease,
		                   itemStats25.itemRadus, itemStats25.itemKnockback, itemStats25.itemforwardMomentum, itemStats25.itemDamagedLoweredPerSecond,itemStats25.itemArcRange,itemStats25.itemDamagedIncresedPerSecond,
		                   itemStats25.itemHpRegain,itemStats25.itemDefense,itemStats25.itemWaterResist,itemStats25.itemGemSlots,itemStats25.itemMeleeCritChanceIncrease,itemStats25.itemWeaponLengthRadiusIncrease,
		                   itemStats25.itemHpRegainIncrease,itemStats25.itemDefenseIncrease,itemStats25.itemMaxHpIncrease,itemStats25.itemMoveSpeedIncrease,itemStats25.itemAttackSpeedIncrease,
		                   itemStats25.itemGpCostReduce,itemStats25.itemGpDamageIncrease,itemStats25.itemGpRegeneration, itemStats25.itemIncreaseBaseMaxHp, itemStats25.itemTypeString));

		items.Add(new Item(item26.name, itemStats26.itemID, itemStats26.itemDesc, itemStats26.itemWidth, itemStats26.itemHeight, itemStats26.itemPower, itemStats26.itemSwingSpeed,itemStats26.itemChargeIncrease,
		                   itemStats26.itemRadus, itemStats26.itemKnockback, itemStats26.itemforwardMomentum, itemStats26.itemDamagedLoweredPerSecond,itemStats26.itemArcRange,itemStats26.itemDamagedIncresedPerSecond,
		                   itemStats26.itemHpRegain,itemStats26.itemDefense,itemStats26.itemWaterResist,itemStats26.itemGemSlots,itemStats26.itemMeleeCritChanceIncrease,itemStats26.itemWeaponLengthRadiusIncrease,
		                   itemStats26.itemHpRegainIncrease,itemStats26.itemDefenseIncrease,itemStats26.itemMaxHpIncrease,itemStats26.itemMoveSpeedIncrease,itemStats26.itemAttackSpeedIncrease,
		                   itemStats26.itemGpCostReduce,itemStats26.itemGpDamageIncrease,itemStats26.itemGpRegeneration, itemStats26.itemIncreaseBaseMaxHp, itemStats26.itemTypeString));


		/* -- Delete this line when creating new item 25
		items.Add(new Item(item25.name, itemStats25.itemID, itemStats25.itemDesc, itemStats25.itemWidth, itemStats25.itemHeight, itemStats25.itemPower, itemStats25.itemSwingSpeed,itemStats25.itemChargeIncrease,
		                   itemStats25.itemRadus, itemStats25.itemKnockback, itemStats25.itemforwardMomentum, itemStats25.itemDamagedLoweredPerSecond,itemStats25.itemArcRange,itemStats25.itemDamagedIncresedPerSecond,
		                   itemStats25.itemHpRegain,itemStats25.itemDefense,itemStats25.itemWaterResist,itemStats25.itemGemSlots,itemStats25.itemMeleeCritChanceIncrease,itemStats25.itemWeaponLengthRadiusIncrease,
		                   itemStats25.itemHpRegainIncrease,itemStats25.itemDefenseIncrease,itemStats25.itemMaxHpIncrease,itemStats25.itemMoveSpeedIncrease,itemStats25.itemAttackSpeedIncrease,
		                   itemStats25.itemGpCostReduce,itemStats25.itemGpDamageIncrease,itemStats25.itemGpRegeneration, itemStats25.itemIncreaseBaseMaxHp));
		 --  Delete this line for item 25*/

		/* -- Delete this line when creating new item 26
		items.Add(new Item(item26.name, itemStats26.itemID, itemStats26.itemDesc, itemStats26.itemWidth, itemStats26.itemHeight, itemStats26.itemPower, itemStats26.itemSwingSpeed,itemStats26.itemChargeIncrease,
		                   itemStats26.itemRadus, itemStats26.itemKnockback, itemStats26.itemforwardMomentum, itemStats26.itemDamagedLoweredPerSecond,itemStats26.itemArcRange,itemStats26.itemDamagedIncresedPerSecond,
		                   itemStats26.itemHpRegain,itemStats26.itemDefense,itemStats26.itemWaterResist,itemStats26.itemGemSlots,itemStats26.itemMeleeCritChanceIncrease,itemStats26.itemWeaponLengthRadiusIncrease,
		                   itemStats26.itemHpRegainIncrease,itemStats26.itemDefenseIncrease,itemStats26.itemMaxHpIncrease,itemStats26.itemMoveSpeedIncrease,itemStats26.itemAttackSpeedIncrease,
		                   itemStats26.itemGpCostReduce,itemStats26.itemGpDamageIncrease,itemStats26.itemGpRegeneration, itemStats26.itemIncreaseBaseMaxHp));
			-- Delete this line when creating new item 26*/

		/* -- Delete this line when creating new item 27
		items.Add(new Item(item27.name, itemStats27.itemID, itemStats27.itemDesc, itemStats27.itemWidth, itemStats27.itemHeight, itemStats27.itemPower, itemStats27.itemSwingSpeed,itemStats27.itemChargeIncrease,
		                   itemStats27.itemRadus, itemStats27.itemKnockback, itemStats27.itemforwardMomentum, itemStats27.itemDamagedLoweredPerSecond,itemStats27.itemArcRange,itemStats27.itemDamagedIncresedPerSecond,
		                   itemStats27.itemHpRegain,itemStats27.itemDefense,itemStats27.itemWaterResist,itemStats27.itemGemSlots,itemStats27.itemMeleeCritChanceIncrease,itemStats27.itemWeaponLengthRadiusIncrease,
		                   itemStats27.itemHpRegainIncrease,itemStats27.itemDefenseIncrease,itemStats27.itemMaxHpIncrease,itemStats27.itemMoveSpeedIncrease,itemStats27.itemAttackSpeedIncrease,
		                   itemStats27.itemGpCostReduce,itemStats27.itemGpDamageIncrease,itemStats27.itemGpRegeneration, itemStats27.itemIncreaseBaseMaxHp));
			-- Delete this line when creating new item 27*/

		/* -- Delete this line when creating new item 28
		items.Add(new Item(item28.name, itemStats28.itemID, itemStats28.itemDesc, itemStats28.itemWidth, itemStats28.itemHeight, itemStats28.itemPower, itemStats28.itemSwingSpeed,itemStats28.itemChargeIncrease,
		                   itemStats28.itemRadus, itemStats28.itemKnockback, itemStats28.itemforwardMomentum, itemStats28.itemDamagedLoweredPerSecond,itemStats28.itemArcRange,itemStats28.itemDamagedIncresedPerSecond,
		                   itemStats28.itemHpRegain,itemStats28.itemDefense,itemStats28.itemWaterResist,itemStats28.itemGemSlots,itemStats28.itemMeleeCritChanceIncrease,itemStats28.itemWeaponLengthRadiusIncrease,
		                   itemStats28.itemHpRegainIncrease,itemStats28.itemDefenseIncrease,itemStats28.itemMaxHpIncrease,itemStats28.itemMoveSpeedIncrease,itemStats28.itemAttackSpeedIncrease,
		                   itemStats28.itemGpCostReduce,itemStats28.itemGpDamageIncrease,itemStats28.itemGpRegeneration, itemStats28.itemIncreaseBaseMaxHp));
		-- Delete this line when creating new item 28*/

		/*-- Delete this line when creating new item 29
		items.Add(new Item(item29.name, itemStats29.itemID, itemStats29.itemDesc, itemStats29.itemWidth, itemStats29.itemHeight, itemStats29.itemPower, itemStats29.itemSwingSpeed,itemStats29.itemChargeIncrease,
		                   itemStats29.itemRadus, itemStats29.itemKnockback, itemStats29.itemforwardMomentum, itemStats29.itemDamagedLoweredPerSecond,itemStats29.itemArcRange,itemStats29.itemDamagedIncresedPerSecond,
		                   itemStats29.itemHpRegain,itemStats29.itemDefense,itemStats29.itemWaterResist,itemStats29.itemGemSlots,itemStats29.itemMeleeCritChanceIncrease,itemStats29.itemWeaponLengthRadiusIncrease,
		                   itemStats29.itemHpRegainIncrease,itemStats29.itemDefenseIncrease,itemStats29.itemMaxHpIncrease,itemStats29.itemMoveSpeedIncrease,itemStats29.itemAttackSpeedIncrease,
		                   itemStats29.itemGpCostReduce,itemStats29.itemGpDamageIncrease,itemStats29.itemGpRegeneration, itemStats29.itemIncreaseBaseMaxHp));
		-- Delete this line when creating new item 29*/

		/*-- Delete this line when creating new item 30
		items.Add(new Item(item30.name, itemStats30.itemID, itemStats30.itemDesc, itemStats30.itemWidth, itemStats30.itemHeight, itemStats30.itemPower, itemStats30.itemSwingSpeed,itemStats30.itemChargeIncrease,
		                   itemStats30.itemRadus, itemStats30.itemKnockback, itemStats30.itemforwardMomentum, itemStats30.itemDamagedLoweredPerSecond,itemStats30.itemArcRange,itemStats30.itemDamagedIncresedPerSecond,
		                   itemStats30.itemHpRegain,itemStats30.itemDefense,itemStats30.itemWaterResist,itemStats30.itemGemSlots,itemStats30.itemMeleeCritChanceIncrease,itemStats30.itemWeaponLengthRadiusIncrease,
		                   itemStats30.itemHpRegainIncrease,itemStats30.itemDefenseIncrease,itemStats30.itemMaxHpIncrease,itemStats30.itemMoveSpeedIncrease,itemStats30.itemAttackSpeedIncrease,
		                   itemStats30.itemGpCostReduce,itemStats30.itemGpDamageIncrease,itemStats30.itemGpRegeneration, itemStats30.itemIncreaseBaseMaxHp));


       -- Delete this line when creating new item 30*/

	}
	
}
