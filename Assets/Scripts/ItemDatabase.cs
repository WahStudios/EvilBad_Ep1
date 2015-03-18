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
	public GameObject item50;
	ItemStats itemStats50;
	public GameObject item51;
	ItemStats itemStats51;
	public GameObject item52;
	ItemStats itemStats52;
	public GameObject item53;
	ItemStats itemStats53;
	public GameObject item54;
	ItemStats itemStats54;
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
		itemStats50 = item50.GetComponent<ItemStats>();
		itemStats51 = item51.GetComponent<ItemStats>();
		/*
		itemStats52 = item52.GetComponent<ItemStats>();
		itemStats53 = item53.GetComponent<ItemStats>();
		itemStats54 = item54.GetComponent<ItemStats>();
*/

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

		items.Add(new Item(item27.name, itemStats27.itemID, itemStats27.itemDesc, itemStats27.itemWidth, itemStats27.itemHeight, itemStats27.itemPower, itemStats27.itemSwingSpeed,itemStats27.itemChargeIncrease,
		                   itemStats27.itemRadus, itemStats27.itemKnockback, itemStats27.itemforwardMomentum, itemStats27.itemDamagedLoweredPerSecond,itemStats27.itemArcRange,itemStats27.itemDamagedIncresedPerSecond,
		                   itemStats27.itemHpRegain,itemStats27.itemDefense,itemStats27.itemWaterResist,itemStats27.itemGemSlots,itemStats27.itemMeleeCritChanceIncrease,itemStats27.itemWeaponLengthRadiusIncrease,
		                   itemStats27.itemHpRegainIncrease,itemStats27.itemDefenseIncrease,itemStats27.itemMaxHpIncrease,itemStats27.itemMoveSpeedIncrease,itemStats27.itemAttackSpeedIncrease,
		                   itemStats27.itemGpCostReduce,itemStats27.itemGpDamageIncrease,itemStats27.itemGpRegeneration, itemStats27.itemIncreaseBaseMaxHp, itemStats27.itemTypeString));

		items.Add(new Item(item28.name, itemStats28.itemID, itemStats28.itemDesc, itemStats28.itemWidth, itemStats28.itemHeight, itemStats28.itemPower, itemStats28.itemSwingSpeed,itemStats28.itemChargeIncrease,
		                   itemStats28.itemRadus, itemStats28.itemKnockback, itemStats28.itemforwardMomentum, itemStats28.itemDamagedLoweredPerSecond,itemStats28.itemArcRange,itemStats28.itemDamagedIncresedPerSecond,
		                   itemStats28.itemHpRegain,itemStats28.itemDefense,itemStats28.itemWaterResist,itemStats28.itemGemSlots,itemStats28.itemMeleeCritChanceIncrease,itemStats28.itemWeaponLengthRadiusIncrease,
		                   itemStats28.itemHpRegainIncrease,itemStats28.itemDefenseIncrease,itemStats28.itemMaxHpIncrease,itemStats28.itemMoveSpeedIncrease,itemStats28.itemAttackSpeedIncrease,
		                   itemStats28.itemGpCostReduce,itemStats28.itemGpDamageIncrease,itemStats28.itemGpRegeneration, itemStats28.itemIncreaseBaseMaxHp, itemStats28.itemTypeString));

		items.Add(new Item(item29.name, itemStats29.itemID, itemStats29.itemDesc, itemStats29.itemWidth, itemStats29.itemHeight, itemStats29.itemPower, itemStats29.itemSwingSpeed,itemStats29.itemChargeIncrease,
		                   itemStats29.itemRadus, itemStats29.itemKnockback, itemStats29.itemforwardMomentum, itemStats29.itemDamagedLoweredPerSecond,itemStats29.itemArcRange,itemStats29.itemDamagedIncresedPerSecond,
		                   itemStats29.itemHpRegain,itemStats29.itemDefense,itemStats29.itemWaterResist,itemStats29.itemGemSlots,itemStats29.itemMeleeCritChanceIncrease,itemStats29.itemWeaponLengthRadiusIncrease,
		                   itemStats29.itemHpRegainIncrease,itemStats29.itemDefenseIncrease,itemStats29.itemMaxHpIncrease,itemStats29.itemMoveSpeedIncrease,itemStats29.itemAttackSpeedIncrease,
		                   itemStats29.itemGpCostReduce,itemStats29.itemGpDamageIncrease,itemStats29.itemGpRegeneration, itemStats29.itemIncreaseBaseMaxHp, itemStats29.itemTypeString));

		items.Add(new Item(item30.name, itemStats30.itemID, itemStats30.itemDesc, itemStats30.itemWidth, itemStats30.itemHeight, itemStats30.itemPower, itemStats30.itemSwingSpeed,itemStats30.itemChargeIncrease,
		                   itemStats30.itemRadus, itemStats30.itemKnockback, itemStats30.itemforwardMomentum, itemStats30.itemDamagedLoweredPerSecond,itemStats30.itemArcRange,itemStats30.itemDamagedIncresedPerSecond,
		                   itemStats30.itemHpRegain,itemStats30.itemDefense,itemStats30.itemWaterResist,itemStats30.itemGemSlots,itemStats30.itemMeleeCritChanceIncrease,itemStats30.itemWeaponLengthRadiusIncrease,
		                   itemStats30.itemHpRegainIncrease,itemStats30.itemDefenseIncrease,itemStats30.itemMaxHpIncrease,itemStats30.itemMoveSpeedIncrease,itemStats30.itemAttackSpeedIncrease,
		                   itemStats30.itemGpCostReduce,itemStats30.itemGpDamageIncrease,itemStats30.itemGpRegeneration, itemStats30.itemIncreaseBaseMaxHp, itemStats30.itemTypeString));

		items.Add(new Item(item31.name, itemStats31.itemID, itemStats31.itemDesc, itemStats31.itemWidth, itemStats31.itemHeight, itemStats31.itemPower, itemStats31.itemSwingSpeed,itemStats31.itemChargeIncrease,
		                   itemStats31.itemRadus, itemStats31.itemKnockback, itemStats31.itemforwardMomentum, itemStats31.itemDamagedLoweredPerSecond,itemStats31.itemArcRange,itemStats31.itemDamagedIncresedPerSecond,
		                   itemStats31.itemHpRegain,itemStats31.itemDefense,itemStats31.itemWaterResist,itemStats31.itemGemSlots,itemStats31.itemMeleeCritChanceIncrease,itemStats31.itemWeaponLengthRadiusIncrease,
		                   itemStats31.itemHpRegainIncrease,itemStats31.itemDefenseIncrease,itemStats31.itemMaxHpIncrease,itemStats31.itemMoveSpeedIncrease,itemStats31.itemAttackSpeedIncrease,
		                   itemStats31.itemGpCostReduce,itemStats31.itemGpDamageIncrease,itemStats31.itemGpRegeneration, itemStats31.itemIncreaseBaseMaxHp, itemStats31.itemTypeString));

		items.Add(new Item(item32.name, itemStats32.itemID, itemStats32.itemDesc, itemStats32.itemWidth, itemStats32.itemHeight, itemStats32.itemPower, itemStats32.itemSwingSpeed,itemStats32.itemChargeIncrease,
		                   itemStats32.itemRadus, itemStats32.itemKnockback, itemStats32.itemforwardMomentum, itemStats32.itemDamagedLoweredPerSecond,itemStats32.itemArcRange,itemStats32.itemDamagedIncresedPerSecond,
		                   itemStats32.itemHpRegain,itemStats32.itemDefense,itemStats32.itemWaterResist,itemStats32.itemGemSlots,itemStats32.itemMeleeCritChanceIncrease,itemStats32.itemWeaponLengthRadiusIncrease,
		                   itemStats32.itemHpRegainIncrease,itemStats32.itemDefenseIncrease,itemStats32.itemMaxHpIncrease,itemStats32.itemMoveSpeedIncrease,itemStats32.itemAttackSpeedIncrease,
		                   itemStats32.itemGpCostReduce,itemStats32.itemGpDamageIncrease,itemStats32.itemGpRegeneration, itemStats32.itemIncreaseBaseMaxHp, itemStats32.itemTypeString));

		items.Add(new Item(item33.name, itemStats33.itemID, itemStats33.itemDesc, itemStats33.itemWidth, itemStats33.itemHeight, itemStats33.itemPower, itemStats33.itemSwingSpeed,itemStats33.itemChargeIncrease,
		                   itemStats33.itemRadus, itemStats33.itemKnockback, itemStats33.itemforwardMomentum, itemStats33.itemDamagedLoweredPerSecond,itemStats33.itemArcRange,itemStats33.itemDamagedIncresedPerSecond,
		                   itemStats33.itemHpRegain,itemStats33.itemDefense,itemStats33.itemWaterResist,itemStats33.itemGemSlots,itemStats33.itemMeleeCritChanceIncrease,itemStats33.itemWeaponLengthRadiusIncrease,
		                   itemStats33.itemHpRegainIncrease,itemStats33.itemDefenseIncrease,itemStats33.itemMaxHpIncrease,itemStats33.itemMoveSpeedIncrease,itemStats33.itemAttackSpeedIncrease,
		                   itemStats33.itemGpCostReduce,itemStats33.itemGpDamageIncrease,itemStats33.itemGpRegeneration, itemStats33.itemIncreaseBaseMaxHp, itemStats33.itemTypeString));

		items.Add(new Item(item34.name, itemStats34.itemID, itemStats34.itemDesc, itemStats34.itemWidth, itemStats34.itemHeight, itemStats34.itemPower, itemStats34.itemSwingSpeed,itemStats34.itemChargeIncrease,
		                   itemStats34.itemRadus, itemStats34.itemKnockback, itemStats34.itemforwardMomentum, itemStats34.itemDamagedLoweredPerSecond,itemStats34.itemArcRange,itemStats34.itemDamagedIncresedPerSecond,
		                   itemStats34.itemHpRegain,itemStats34.itemDefense,itemStats34.itemWaterResist,itemStats34.itemGemSlots,itemStats34.itemMeleeCritChanceIncrease,itemStats34.itemWeaponLengthRadiusIncrease,
		                   itemStats34.itemHpRegainIncrease,itemStats34.itemDefenseIncrease,itemStats34.itemMaxHpIncrease,itemStats34.itemMoveSpeedIncrease,itemStats34.itemAttackSpeedIncrease,
		                   itemStats34.itemGpCostReduce,itemStats34.itemGpDamageIncrease,itemStats34.itemGpRegeneration, itemStats34.itemIncreaseBaseMaxHp, itemStats34.itemTypeString));

		items.Add(new Item(item35.name, itemStats35.itemID, itemStats35.itemDesc, itemStats35.itemWidth, itemStats35.itemHeight, itemStats35.itemPower, itemStats35.itemSwingSpeed,itemStats35.itemChargeIncrease,
		                   itemStats35.itemRadus, itemStats35.itemKnockback, itemStats35.itemforwardMomentum, itemStats35.itemDamagedLoweredPerSecond,itemStats35.itemArcRange,itemStats35.itemDamagedIncresedPerSecond,
		                   itemStats35.itemHpRegain,itemStats35.itemDefense,itemStats35.itemWaterResist,itemStats35.itemGemSlots,itemStats35.itemMeleeCritChanceIncrease,itemStats35.itemWeaponLengthRadiusIncrease,
		                   itemStats35.itemHpRegainIncrease,itemStats35.itemDefenseIncrease,itemStats35.itemMaxHpIncrease,itemStats35.itemMoveSpeedIncrease,itemStats35.itemAttackSpeedIncrease,
		                   itemStats35.itemGpCostReduce,itemStats35.itemGpDamageIncrease,itemStats35.itemGpRegeneration, itemStats35.itemIncreaseBaseMaxHp, itemStats35.itemTypeString));

		items.Add(new Item(item36.name, itemStats36.itemID, itemStats36.itemDesc, itemStats36.itemWidth, itemStats36.itemHeight, itemStats36.itemPower, itemStats36.itemSwingSpeed,itemStats36.itemChargeIncrease,
		                   itemStats36.itemRadus, itemStats36.itemKnockback, itemStats36.itemforwardMomentum, itemStats36.itemDamagedLoweredPerSecond,itemStats36.itemArcRange,itemStats36.itemDamagedIncresedPerSecond,
		                   itemStats36.itemHpRegain,itemStats36.itemDefense,itemStats36.itemWaterResist,itemStats36.itemGemSlots,itemStats36.itemMeleeCritChanceIncrease,itemStats36.itemWeaponLengthRadiusIncrease,
		                   itemStats36.itemHpRegainIncrease,itemStats36.itemDefenseIncrease,itemStats36.itemMaxHpIncrease,itemStats36.itemMoveSpeedIncrease,itemStats36.itemAttackSpeedIncrease,
		                   itemStats36.itemGpCostReduce,itemStats36.itemGpDamageIncrease,itemStats36.itemGpRegeneration, itemStats36.itemIncreaseBaseMaxHp, itemStats36.itemTypeString));

		items.Add(new Item(item37.name, itemStats37.itemID, itemStats37.itemDesc, itemStats37.itemWidth, itemStats37.itemHeight, itemStats37.itemPower, itemStats37.itemSwingSpeed,itemStats37.itemChargeIncrease,
		                   itemStats37.itemRadus, itemStats37.itemKnockback, itemStats37.itemforwardMomentum, itemStats37.itemDamagedLoweredPerSecond,itemStats37.itemArcRange,itemStats37.itemDamagedIncresedPerSecond,
		                   itemStats37.itemHpRegain,itemStats37.itemDefense,itemStats37.itemWaterResist,itemStats37.itemGemSlots,itemStats37.itemMeleeCritChanceIncrease,itemStats37.itemWeaponLengthRadiusIncrease,
		                   itemStats37.itemHpRegainIncrease,itemStats37.itemDefenseIncrease,itemStats37.itemMaxHpIncrease,itemStats37.itemMoveSpeedIncrease,itemStats37.itemAttackSpeedIncrease,
		                   itemStats37.itemGpCostReduce,itemStats37.itemGpDamageIncrease,itemStats37.itemGpRegeneration, itemStats37.itemIncreaseBaseMaxHp, itemStats37.itemTypeString));

		items.Add(new Item(item38.name, itemStats38.itemID, itemStats38.itemDesc, itemStats38.itemWidth, itemStats38.itemHeight, itemStats38.itemPower, itemStats38.itemSwingSpeed,itemStats38.itemChargeIncrease,
		                   itemStats38.itemRadus, itemStats38.itemKnockback, itemStats38.itemforwardMomentum, itemStats38.itemDamagedLoweredPerSecond,itemStats38.itemArcRange,itemStats38.itemDamagedIncresedPerSecond,
		                   itemStats38.itemHpRegain,itemStats38.itemDefense,itemStats38.itemWaterResist,itemStats38.itemGemSlots,itemStats38.itemMeleeCritChanceIncrease,itemStats38.itemWeaponLengthRadiusIncrease,
		                   itemStats38.itemHpRegainIncrease,itemStats38.itemDefenseIncrease,itemStats38.itemMaxHpIncrease,itemStats38.itemMoveSpeedIncrease,itemStats38.itemAttackSpeedIncrease,
		                   itemStats38.itemGpCostReduce,itemStats38.itemGpDamageIncrease,itemStats38.itemGpRegeneration, itemStats38.itemIncreaseBaseMaxHp, itemStats38.itemTypeString));

		items.Add(new Item(item39.name, itemStats39.itemID, itemStats39.itemDesc, itemStats39.itemWidth, itemStats39.itemHeight, itemStats39.itemPower, itemStats39.itemSwingSpeed,itemStats39.itemChargeIncrease,
		                   itemStats39.itemRadus, itemStats39.itemKnockback, itemStats39.itemforwardMomentum, itemStats39.itemDamagedLoweredPerSecond,itemStats39.itemArcRange,itemStats39.itemDamagedIncresedPerSecond,
		                   itemStats39.itemHpRegain,itemStats39.itemDefense,itemStats39.itemWaterResist,itemStats39.itemGemSlots,itemStats39.itemMeleeCritChanceIncrease,itemStats39.itemWeaponLengthRadiusIncrease,
		                   itemStats39.itemHpRegainIncrease,itemStats39.itemDefenseIncrease,itemStats39.itemMaxHpIncrease,itemStats39.itemMoveSpeedIncrease,itemStats39.itemAttackSpeedIncrease,
		                   itemStats39.itemGpCostReduce,itemStats39.itemGpDamageIncrease,itemStats39.itemGpRegeneration, itemStats39.itemIncreaseBaseMaxHp, itemStats39.itemTypeString));

		items.Add(new Item(item40.name, itemStats40.itemID, itemStats40.itemDesc, itemStats40.itemWidth, itemStats40.itemHeight, itemStats40.itemPower, itemStats40.itemSwingSpeed,itemStats40.itemChargeIncrease,
		                   itemStats40.itemRadus, itemStats40.itemKnockback, itemStats40.itemforwardMomentum, itemStats40.itemDamagedLoweredPerSecond,itemStats40.itemArcRange,itemStats40.itemDamagedIncresedPerSecond,
		                   itemStats40.itemHpRegain,itemStats40.itemDefense,itemStats40.itemWaterResist,itemStats40.itemGemSlots,itemStats40.itemMeleeCritChanceIncrease,itemStats40.itemWeaponLengthRadiusIncrease,
		                   itemStats40.itemHpRegainIncrease,itemStats40.itemDefenseIncrease,itemStats40.itemMaxHpIncrease,itemStats40.itemMoveSpeedIncrease,itemStats40.itemAttackSpeedIncrease,
		                   itemStats40.itemGpCostReduce,itemStats40.itemGpDamageIncrease,itemStats40.itemGpRegeneration, itemStats40.itemIncreaseBaseMaxHp, itemStats40.itemTypeString));

		items.Add(new Item(item41.name, itemStats41.itemID, itemStats41.itemDesc, itemStats41.itemWidth, itemStats41.itemHeight, itemStats41.itemPower, itemStats41.itemSwingSpeed,itemStats41.itemChargeIncrease,
		                   itemStats41.itemRadus, itemStats41.itemKnockback, itemStats41.itemforwardMomentum, itemStats41.itemDamagedLoweredPerSecond,itemStats41.itemArcRange,itemStats41.itemDamagedIncresedPerSecond,
		                   itemStats41.itemHpRegain,itemStats41.itemDefense,itemStats41.itemWaterResist,itemStats41.itemGemSlots,itemStats41.itemMeleeCritChanceIncrease,itemStats41.itemWeaponLengthRadiusIncrease,
		                   itemStats41.itemHpRegainIncrease,itemStats41.itemDefenseIncrease,itemStats41.itemMaxHpIncrease,itemStats41.itemMoveSpeedIncrease,itemStats41.itemAttackSpeedIncrease,
		                   itemStats41.itemGpCostReduce,itemStats41.itemGpDamageIncrease,itemStats41.itemGpRegeneration, itemStats41.itemIncreaseBaseMaxHp, itemStats41.itemTypeString));

		items.Add(new Item(item42.name, itemStats42.itemID, itemStats42.itemDesc, itemStats42.itemWidth, itemStats42.itemHeight, itemStats42.itemPower, itemStats42.itemSwingSpeed,itemStats42.itemChargeIncrease,
		                   itemStats42.itemRadus, itemStats42.itemKnockback, itemStats42.itemforwardMomentum, itemStats42.itemDamagedLoweredPerSecond,itemStats42.itemArcRange,itemStats42.itemDamagedIncresedPerSecond,
		                   itemStats42.itemHpRegain,itemStats42.itemDefense,itemStats42.itemWaterResist,itemStats42.itemGemSlots,itemStats42.itemMeleeCritChanceIncrease,itemStats42.itemWeaponLengthRadiusIncrease,
		                   itemStats42.itemHpRegainIncrease,itemStats42.itemDefenseIncrease,itemStats42.itemMaxHpIncrease,itemStats42.itemMoveSpeedIncrease,itemStats42.itemAttackSpeedIncrease,
		                   itemStats42.itemGpCostReduce,itemStats42.itemGpDamageIncrease,itemStats42.itemGpRegeneration, itemStats42.itemIncreaseBaseMaxHp, itemStats42.itemTypeString));

		items.Add(new Item(item43.name, itemStats43.itemID, itemStats43.itemDesc, itemStats43.itemWidth, itemStats43.itemHeight, itemStats43.itemPower, itemStats43.itemSwingSpeed,itemStats43.itemChargeIncrease,
		                   itemStats43.itemRadus, itemStats43.itemKnockback, itemStats43.itemforwardMomentum, itemStats43.itemDamagedLoweredPerSecond,itemStats43.itemArcRange,itemStats43.itemDamagedIncresedPerSecond,
		                   itemStats43.itemHpRegain,itemStats43.itemDefense,itemStats43.itemWaterResist,itemStats43.itemGemSlots,itemStats43.itemMeleeCritChanceIncrease,itemStats43.itemWeaponLengthRadiusIncrease,
		                   itemStats43.itemHpRegainIncrease,itemStats43.itemDefenseIncrease,itemStats43.itemMaxHpIncrease,itemStats43.itemMoveSpeedIncrease,itemStats43.itemAttackSpeedIncrease,
		                   itemStats43.itemGpCostReduce,itemStats43.itemGpDamageIncrease,itemStats43.itemGpRegeneration, itemStats43.itemIncreaseBaseMaxHp, itemStats43.itemTypeString));

		items.Add(new Item(item44.name, itemStats44.itemID, itemStats44.itemDesc, itemStats44.itemWidth, itemStats44.itemHeight, itemStats44.itemPower, itemStats44.itemSwingSpeed,itemStats44.itemChargeIncrease,
		                   itemStats44.itemRadus, itemStats44.itemKnockback, itemStats44.itemforwardMomentum, itemStats44.itemDamagedLoweredPerSecond,itemStats44.itemArcRange,itemStats44.itemDamagedIncresedPerSecond,
		                   itemStats44.itemHpRegain,itemStats44.itemDefense,itemStats44.itemWaterResist,itemStats44.itemGemSlots,itemStats44.itemMeleeCritChanceIncrease,itemStats44.itemWeaponLengthRadiusIncrease,
		                   itemStats44.itemHpRegainIncrease,itemStats44.itemDefenseIncrease,itemStats44.itemMaxHpIncrease,itemStats44.itemMoveSpeedIncrease,itemStats44.itemAttackSpeedIncrease,
		                   itemStats44.itemGpCostReduce,itemStats44.itemGpDamageIncrease,itemStats44.itemGpRegeneration, itemStats44.itemIncreaseBaseMaxHp, itemStats44.itemTypeString));

		items.Add(new Item(item45.name, itemStats45.itemID, itemStats45.itemDesc, itemStats45.itemWidth, itemStats45.itemHeight, itemStats45.itemPower, itemStats45.itemSwingSpeed,itemStats45.itemChargeIncrease,
		                   itemStats45.itemRadus, itemStats45.itemKnockback, itemStats45.itemforwardMomentum, itemStats45.itemDamagedLoweredPerSecond,itemStats45.itemArcRange,itemStats45.itemDamagedIncresedPerSecond,
		                   itemStats45.itemHpRegain,itemStats45.itemDefense,itemStats45.itemWaterResist,itemStats45.itemGemSlots,itemStats45.itemMeleeCritChanceIncrease,itemStats45.itemWeaponLengthRadiusIncrease,
		                   itemStats45.itemHpRegainIncrease,itemStats45.itemDefenseIncrease,itemStats45.itemMaxHpIncrease,itemStats45.itemMoveSpeedIncrease,itemStats45.itemAttackSpeedIncrease,
		                   itemStats45.itemGpCostReduce,itemStats45.itemGpDamageIncrease,itemStats45.itemGpRegeneration, itemStats45.itemIncreaseBaseMaxHp, itemStats45.itemTypeString));

		items.Add(new Item(item46.name, itemStats46.itemID, itemStats46.itemDesc, itemStats46.itemWidth, itemStats46.itemHeight, itemStats46.itemPower, itemStats46.itemSwingSpeed,itemStats46.itemChargeIncrease,
		                   itemStats46.itemRadus, itemStats46.itemKnockback, itemStats46.itemforwardMomentum, itemStats46.itemDamagedLoweredPerSecond,itemStats46.itemArcRange,itemStats46.itemDamagedIncresedPerSecond,
		                   itemStats46.itemHpRegain,itemStats46.itemDefense,itemStats46.itemWaterResist,itemStats46.itemGemSlots,itemStats46.itemMeleeCritChanceIncrease,itemStats46.itemWeaponLengthRadiusIncrease,
		                   itemStats46.itemHpRegainIncrease,itemStats46.itemDefenseIncrease,itemStats46.itemMaxHpIncrease,itemStats46.itemMoveSpeedIncrease,itemStats46.itemAttackSpeedIncrease,
		                   itemStats46.itemGpCostReduce,itemStats46.itemGpDamageIncrease,itemStats46.itemGpRegeneration, itemStats46.itemIncreaseBaseMaxHp, itemStats46.itemTypeString));

		items.Add(new Item(item47.name, itemStats47.itemID, itemStats47.itemDesc, itemStats47.itemWidth, itemStats47.itemHeight, itemStats47.itemPower, itemStats47.itemSwingSpeed,itemStats47.itemChargeIncrease,
		                   itemStats47.itemRadus, itemStats47.itemKnockback, itemStats47.itemforwardMomentum, itemStats47.itemDamagedLoweredPerSecond,itemStats47.itemArcRange,itemStats47.itemDamagedIncresedPerSecond,
		                   itemStats47.itemHpRegain,itemStats47.itemDefense,itemStats47.itemWaterResist,itemStats47.itemGemSlots,itemStats47.itemMeleeCritChanceIncrease,itemStats47.itemWeaponLengthRadiusIncrease,
		                   itemStats47.itemHpRegainIncrease,itemStats47.itemDefenseIncrease,itemStats47.itemMaxHpIncrease,itemStats47.itemMoveSpeedIncrease,itemStats47.itemAttackSpeedIncrease,
		                   itemStats47.itemGpCostReduce,itemStats47.itemGpDamageIncrease,itemStats47.itemGpRegeneration, itemStats47.itemIncreaseBaseMaxHp, itemStats47.itemTypeString));

		items.Add(new Item(item48.name, itemStats48.itemID, itemStats48.itemDesc, itemStats48.itemWidth, itemStats48.itemHeight, itemStats48.itemPower, itemStats48.itemSwingSpeed,itemStats48.itemChargeIncrease,
		                   itemStats48.itemRadus, itemStats48.itemKnockback, itemStats48.itemforwardMomentum, itemStats48.itemDamagedLoweredPerSecond,itemStats48.itemArcRange,itemStats48.itemDamagedIncresedPerSecond,
		                   itemStats48.itemHpRegain,itemStats48.itemDefense,itemStats48.itemWaterResist,itemStats48.itemGemSlots,itemStats48.itemMeleeCritChanceIncrease,itemStats48.itemWeaponLengthRadiusIncrease,
		                   itemStats48.itemHpRegainIncrease,itemStats48.itemDefenseIncrease,itemStats48.itemMaxHpIncrease,itemStats48.itemMoveSpeedIncrease,itemStats48.itemAttackSpeedIncrease,
		                   itemStats48.itemGpCostReduce,itemStats48.itemGpDamageIncrease,itemStats48.itemGpRegeneration, itemStats48.itemIncreaseBaseMaxHp, itemStats48.itemTypeString));

		items.Add(new Item(item49.name, itemStats49.itemID, itemStats49.itemDesc, itemStats49.itemWidth, itemStats49.itemHeight, itemStats49.itemPower, itemStats49.itemSwingSpeed,itemStats49.itemChargeIncrease,
		                   itemStats49.itemRadus, itemStats49.itemKnockback, itemStats49.itemforwardMomentum, itemStats49.itemDamagedLoweredPerSecond,itemStats49.itemArcRange,itemStats49.itemDamagedIncresedPerSecond,
		                   itemStats49.itemHpRegain,itemStats49.itemDefense,itemStats49.itemWaterResist,itemStats49.itemGemSlots,itemStats49.itemMeleeCritChanceIncrease,itemStats49.itemWeaponLengthRadiusIncrease,
		                   itemStats49.itemHpRegainIncrease,itemStats49.itemDefenseIncrease,itemStats49.itemMaxHpIncrease,itemStats49.itemMoveSpeedIncrease,itemStats49.itemAttackSpeedIncrease,
		                   itemStats49.itemGpCostReduce,itemStats49.itemGpDamageIncrease,itemStats49.itemGpRegeneration, itemStats49.itemIncreaseBaseMaxHp, itemStats49.itemTypeString));

		items.Add(new Item(item50.name, itemStats50.itemID, itemStats50.itemDesc, itemStats50.itemWidth, itemStats50.itemHeight, itemStats50.itemPower, itemStats50.itemSwingSpeed,itemStats50.itemChargeIncrease,
		                   itemStats50.itemRadus, itemStats50.itemKnockback, itemStats50.itemforwardMomentum, itemStats50.itemDamagedLoweredPerSecond,itemStats50.itemArcRange,itemStats50.itemDamagedIncresedPerSecond,
		                   itemStats50.itemHpRegain,itemStats50.itemDefense,itemStats50.itemWaterResist,itemStats50.itemGemSlots,itemStats50.itemMeleeCritChanceIncrease,itemStats50.itemWeaponLengthRadiusIncrease,
		                   itemStats50.itemHpRegainIncrease,itemStats50.itemDefenseIncrease,itemStats50.itemMaxHpIncrease,itemStats50.itemMoveSpeedIncrease,itemStats50.itemAttackSpeedIncrease,
		                   itemStats50.itemGpCostReduce,itemStats50.itemGpDamageIncrease,itemStats50.itemGpRegeneration, itemStats50.itemIncreaseBaseMaxHp, itemStats50.itemTypeString));

		items.Add(new Item(item51.name, itemStats51.itemID, itemStats51.itemDesc, itemStats51.itemWidth, itemStats51.itemHeight, itemStats51.itemPower, itemStats51.itemSwingSpeed,itemStats51.itemChargeIncrease,
		                   itemStats51.itemRadus, itemStats51.itemKnockback, itemStats51.itemforwardMomentum, itemStats51.itemDamagedLoweredPerSecond,itemStats51.itemArcRange,itemStats51.itemDamagedIncresedPerSecond,
		                   itemStats51.itemHpRegain,itemStats51.itemDefense,itemStats51.itemWaterResist,itemStats51.itemGemSlots,itemStats51.itemMeleeCritChanceIncrease,itemStats51.itemWeaponLengthRadiusIncrease,
		                   itemStats51.itemHpRegainIncrease,itemStats51.itemDefenseIncrease,itemStats51.itemMaxHpIncrease,itemStats51.itemMoveSpeedIncrease,itemStats51.itemAttackSpeedIncrease,
		                   itemStats51.itemGpCostReduce,itemStats51.itemGpDamageIncrease,itemStats51.itemGpRegeneration, itemStats51.itemIncreaseBaseMaxHp, itemStats51.itemTypeString));
		/*
		items.Add(new Item(item52.name, itemStats52.itemID, itemStats52.itemDesc, itemStats52.itemWidth, itemStats52.itemHeight, itemStats52.itemPower, itemStats52.itemSwingSpeed,itemStats52.itemChargeIncrease,
		                   itemStats52.itemRadus, itemStats52.itemKnockback, itemStats52.itemforwardMomentum, itemStats52.itemDamagedLoweredPerSecond,itemStats52.itemArcRange,itemStats52.itemDamagedIncresedPerSecond,
		                   itemStats52.itemHpRegain,itemStats52.itemDefense,itemStats52.itemWaterResist,itemStats52.itemGemSlots,itemStats52.itemMeleeCritChanceIncrease,itemStats52.itemWeaponLengthRadiusIncrease,
		                   itemStats52.itemHpRegainIncrease,itemStats52.itemDefenseIncrease,itemStats52.itemMaxHpIncrease,itemStats52.itemMoveSpeedIncrease,itemStats52.itemAttackSpeedIncrease,
		                   itemStats52.itemGpCostReduce,itemStats52.itemGpDamageIncrease,itemStats52.itemGpRegeneration, itemStats52.itemIncreaseBaseMaxHp, itemStats52.itemTypeString));

		items.Add(new Item(item53.name, itemStats53.itemID, itemStats53.itemDesc, itemStats53.itemWidth, itemStats53.itemHeight, itemStats53.itemPower, itemStats53.itemSwingSpeed,itemStats53.itemChargeIncrease,
		                   itemStats53.itemRadus, itemStats53.itemKnockback, itemStats53.itemforwardMomentum, itemStats53.itemDamagedLoweredPerSecond,itemStats53.itemArcRange,itemStats53.itemDamagedIncresedPerSecond,
		                   itemStats53.itemHpRegain,itemStats53.itemDefense,itemStats53.itemWaterResist,itemStats53.itemGemSlots,itemStats53.itemMeleeCritChanceIncrease,itemStats53.itemWeaponLengthRadiusIncrease,
		                   itemStats53.itemHpRegainIncrease,itemStats53.itemDefenseIncrease,itemStats53.itemMaxHpIncrease,itemStats53.itemMoveSpeedIncrease,itemStats53.itemAttackSpeedIncrease,
		                   itemStats53.itemGpCostReduce,itemStats53.itemGpDamageIncrease,itemStats53.itemGpRegeneration, itemStats53.itemIncreaseBaseMaxHp, itemStats53.itemTypeString));

		items.Add(new Item(item54.name, itemStats54.itemID, itemStats54.itemDesc, itemStats54.itemWidth, itemStats54.itemHeight, itemStats54.itemPower, itemStats54.itemSwingSpeed,itemStats54.itemChargeIncrease,
		                   itemStats54.itemRadus, itemStats54.itemKnockback, itemStats54.itemforwardMomentum, itemStats54.itemDamagedLoweredPerSecond,itemStats54.itemArcRange,itemStats54.itemDamagedIncresedPerSecond,
		                   itemStats54.itemHpRegain,itemStats54.itemDefense,itemStats54.itemWaterResist,itemStats54.itemGemSlots,itemStats54.itemMeleeCritChanceIncrease,itemStats54.itemWeaponLengthRadiusIncrease,
		                   itemStats54.itemHpRegainIncrease,itemStats54.itemDefenseIncrease,itemStats54.itemMaxHpIncrease,itemStats54.itemMoveSpeedIncrease,itemStats54.itemAttackSpeedIncrease,
		                   itemStats54.itemGpCostReduce,itemStats54.itemGpDamageIncrease,itemStats54.itemGpRegeneration, itemStats54.itemIncreaseBaseMaxHp, itemStats54.itemTypeString));
		*/

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
