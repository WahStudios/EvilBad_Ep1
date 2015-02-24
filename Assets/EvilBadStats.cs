using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EvilBadStats : MonoBehaviour {
	public Text statText;

	public float CD;

	public float HP;
	public float maxHp;
	public float bonusMaxHP;
	public float HPRegen;
	public float HPAbsorb;


	public float GP;
	public float MaxGP;
	public float GPDamage;
	public float GPRegen;
	public float GPAbsorb;
	public float BonusGPDamage; 
	public float BonusGPRegeneration;
	public float GPCostReduce;
	public float GPCritDamage;
	public float GPCritChance;
	public float GPCritBonusDamage;
	public float GPResistance;
	public float GPCostIncreased;
	public float GPCostReduced;

	public float minMagicDamage;
	public float fireBallDamage;
	// elemental damages:
	public float elementalEarthDamage;
	public float elementalBonusEarthDamage;
	public float elementalFireDamage;
	public float elementalBonusFireDamage;
	public float elementalLightDamage;
	public float elementalBonusLightDamage;
	public float elementalShadowDamage;
	public float elementalBonusShadowDamage;
	public float elementalWaterDamage;
	public float elementalBonusWaterDamage;
	public float elementalWindDamage;
	public float elementalBonusWindDamage;





	//[SerializeField]string WeaponStats = "Weapon Attributes";
	public float wrath; //each increase multiple stats, check doc
	public float vengeance;
	public float awe;
	public float mercy; //^^^^^^^^^^^^^^^

	//enchantment chance
	public float chanceOnDamage;
	public float chanceOnGPCrit;
	public float chanceOnMeleeCrit;
	public float chanceOnShieldHit;
	public float chanceOnStrike;
	public float passive;
	//end of enchantment chance



	//	[SerializeField]string SummonStats = "Summon Attributes";
	public float summonHP;
	public float summonGP;
	public float summonMaxHP;
	public float summonMaxGP;
	public float summonMindControl;
	public float summonAttackSpeed;
	public float summonMeleeDamage;
	public float summonBonusMeleeDamage;
	public float summonMovementSpeed;
	public float summonBonusMovementSpeed;

	
	//melee attrib
	public float power;
	public float charge;
	public float arcRange;
	public float SwingSpeed; 
	public float AttackSpeed; 
	public float AttackSpeedTimer;
	public float maxMeleeDamage;
	public float bonusMaxMeleeDamage;
	public float minMeleeDamage;
	public float physicalDamageIncreasedTimer;
	public float knockback;
	public float forwardMomentum;
	public float meleeCritChance;
	public float meleeCritDamage;
	public float meleeSpeed;
	public float maxWeaponDamage;
	public float damageLoweredPerSecond;
	public float damageIncreasedPerSecond;

		
	//[SerializeField]string SelfStats = "Self Attributes";


	public float moveSpeed;
	public float bonusMoveSpeed;
	public float jumpHeight;

	public float experience;
	public float experienceBonus;

	public float goldDrop;
	public float goldDropBonus;
	


	
//	[SerializeField]string GodStats = "God Attributes";





	public float shieldHP;
	public float shieldCD;
	public float shieldHealRate;

	//[SerializeField]string DefenseStats = "Defense Attributes";
	public float defense;
	public float lowerDefenseTimer;
	public float armorBonus;
	public float evade;
	public float reflectChance;
	public float reflectGPDamage;
	public float reflectMeleeDamage;
	public float lifeSteal;
	public float luck;
	public float exodus;
	//[SerializeField]string ResistanceStats = "Resistance Attributes";
	public float resistPhysicalDamage;

	public float resistFire;
	public float bonusResistFire;
	public float bonusResistShadow;
	public float resistShadow;
	public float resistLight;
	public float resistWater;
	public float resistWind;

	public float resistEarth;
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

	public float vengeanceTimer;
	public float weakenedTimer;
	public float wrathTimer;
	public float slowTimer;
	public float speedTimer;
	public float stunTimer;
	public float poisonTimer;
	public float aweTimer;
	public float frightTimer;
	public float gloryTimer;
	public float burnTimer;
	public float bleedTimer;
	public float blindTimer;
	public float GPDamageUpTimer;
	public float armCrushTimer;
	public float blasphemedTimer;
	public float curseTimer;
	public float muffledTimer;
	public float brainFartTimer;

	//debuffs
	public bool mindControled;
	public bool blasphemed;
	public bool frozen;
	public bool wet;
	public bool headache;
	public bool cursed;
	public bool resistanceDown;
	public bool magnetized;
	public bool armCrushed;
	public bool fright;
	public bool muffled;
	public bool brainFart;

	public ItemStats equippedWeaponStats;
	public ItemStats equippedArmorStats;
	public ItemStats equippedHandsStats;
	public ItemStats equippedHeadStats;
	public ItemStats equippedFeetStats;
	public ItemStats equippedWaistStats;
	public ItemStats equippedShieldStats;
	public ItemStats equippedNeckStats;
	public ItemStats equippedRing1Stats;
	public ItemStats equippedRing2Stats;

	public GameObject equippedWeapon;
	public GameObject equippedArmor;
	public GameObject equippedHands;
	public GameObject equippedHead;
	public GameObject equippedFeet;
	public GameObject equippedWaste;
	public GameObject equippedShield;
	public GameObject equippedNeck;
	public GameObject equippedRing1;
	public GameObject equippedRing2;


	public bool isEquippedWeapon = false;
	public bool isEquippedArmor = false;
	public bool isEquippedHands = false;
	public bool isEquippedHead = false;
	public bool isEquippedFeet = false;
	public bool isEquippedWaste = false;
	public bool isEquippedShield = false;
	public bool isEquippedNeck = false;
	public bool isEquippedRing1 = false;
	public bool isEquippedRing2 = false;

	public bool equipWeapon = false;
	public bool equipArmor = false;
	public bool equipHands = false;
	public bool equipHead = false;
	public bool equipFeet = false;
	public bool equipWaste = false;
	public bool equipShield = false;
	public bool equipNeck = false;
	public bool equipRing1 = false;
	public bool equipRing2 = false;

	public bool equippingWeapon = false;
	public bool equippingArmor = false;
	public bool equippingHands = false;
	public bool equippingFeet = false;
	public bool equippingHead = false;
	public bool equippingNeck = false;
	public bool equippingWaste = false;
	public bool equippingShield = false;
	public bool equippingRing1 = false;
	public bool equippingRing2 = false;

	void Start(){


	}

	// Use this for initialization


	void Update(){

		statText.text = "Evil Bad's Stats : \n" +
			"HP " + HP.ToString() + "\n" +
			"MaxHP " + maxHp.ToString() + "\n" +
			"BonusMaxHP " + bonusMaxHP.ToString() + "\n" +
				"HPRegen " + HPRegen.ToString();




		if(equippedWeapon != null)
			equippedWeaponStats = equippedWeapon.gameObject.GetComponent<ItemStats>();
		else
			equippedWeaponStats = null;
		if(equippedArmor != null)
			equippedArmorStats = equippedArmor.gameObject.GetComponent<ItemStats>();
		else 
			equippedArmorStats = null;
		if(equippedHands != null)
			equippedHandsStats = equippedHands.gameObject.GetComponent<ItemStats>();
		else
			equippedHandsStats = null;
		if(equippedFeet != null)
			equippedFeetStats = equippedFeet.gameObject.GetComponent<ItemStats>();
		else
			equippedFeetStats = null;
		if(equippedRing1 != null)
			equippedRing1Stats = equippedRing1.gameObject.GetComponent<ItemStats>();
		else 
			equippedRing1Stats = null;
		if(equippedRing2 != null)
			equippedRing2Stats = equippedRing2.gameObject.GetComponent<ItemStats>();
		else
			equippedRing2Stats = null;
		if(equippedHead != null)
			equippedHeadStats = equippedHead.gameObject.GetComponent<ItemStats>();
		else
			equippedHeadStats = null;
		if(equippedNeck != null)
			equippedNeckStats = equippedNeck.gameObject.GetComponent<ItemStats>();
		else
			equippedNeckStats = null;
		if(equippedWaste != null)
			equippedWaistStats = equippedWaste.gameObject.GetComponent<ItemStats>();
		else
			equippedWaistStats = null;
		if(equippedShield != null)
			equippedShieldStats = equippedShield.gameObject.GetComponent<ItemStats>();
		else
			equippedShieldStats = null;


		if(equippedWeapon != null && equipWeapon == true){
			if(equippingWeapon == false)
			{

		HP += equippedWeaponStats.HP;
		CD += equippedWeaponStats.CD;
		GPRegen += equippedWeaponStats.GPrate;
		fireBallDamage += equippedWeaponStats.fireBallDamageIncreased;
		wrath += equippedWeaponStats.increaseWrath;
		power += equippedWeaponStats.itemPower;
		SwingSpeed += equippedWeaponStats.itemSwingSpeed;
		AttackSpeed += equippedWeaponStats.itemAttackSpeedIncrease;
		arcRange += equippedWeaponStats.itemArcRange;
		charge += equippedWeaponStats.itemChargeIncrease;
		knockback += equippedWeaponStats.itemKnockback;
		forwardMomentum += equippedWeaponStats.itemforwardMomentum;
		meleeCritChance += equippedWeaponStats.itemMeleeCritChanceIncrease;
		meleeCritDamage += equippedWeaponStats.increaseMeleeCritDamage;
		meleeSpeed += equippedWeaponStats.increaseMeleeSpeed;
		maxMeleeDamage += equippedWeaponStats.increaseMeleeMax;
		maxWeaponDamage += equippedWeaponStats.increaseMaxWeaponDamage;
		awe += equippedWeaponStats.increaseAwe;
		HPRegen += equippedWeaponStats.itemHpRegain;
		HPRegen += equippedWeaponStats.itemHpRegainIncrease;
		maxHp += equippedWeaponStats.itemMaxHpIncrease;
		maxHp += equippedWeaponStats.itemIncreaseBaseMaxHp;//double
		moveSpeed += equippedWeaponStats.itemMoveSpeedIncrease;
		jumpHeight += equippedWeaponStats.increaseJumpHeight;
		mercy += equippedWeaponStats.increaseMercy;
		summonMaxHP += equippedWeaponStats.increaseSummonMaxHP;
		summonMaxGP += equippedWeaponStats.increaseSummonMaxGP;
		summonMindControl += equippedWeaponStats.increaseSummonedMindControl;
		vengeance += equippedWeaponStats.increaseVengeance;
		exodus += equippedWeaponStats.increaseExodus;
		GPCostReduce += equippedWeaponStats.itemGpCostReduce;
		GPDamage += equippedWeaponStats.itemGpDamageIncrease;
		GPRegen += equippedWeaponStats.increaseGPregeneration;
		GPRegen += equippedWeaponStats.itemGpRegeneration;//double
		GPCritBonusDamage += equippedWeaponStats.increaseGPCritBonusDamage;
		MaxGP += equippedWeaponStats.maxGPincrease;
		GPResistance += equippedWeaponStats.increaseGPresistance;
		MaxGP += equippedWeaponStats.increaseMaxGP;//double
		GPCritDamage += equippedWeaponStats.increaseGPcritDamage;
		defense += equippedWeaponStats.itemDefense;
		defense += equippedWeaponStats.itemDefenseIncrease; //double
		armorBonus += equippedWeaponStats.increaseArmorBonus;
		resistWater += equippedWeaponStats.itemWaterResist;
		bonusResistFire += equippedWeaponStats.increaseBonusResistFire;
		bonusResistShadow += equippedWeaponStats.increaseBonusResistShadow;
		resistLight += equippedWeaponStats.resistLight;
		resistBlind += equippedWeaponStats.resistBlind;
		resistMelted += equippedWeaponStats.resistMelted;
		resistPoision += equippedWeaponStats.resistPoision;
		resistSlow += equippedWeaponStats.resistSlow;
		resistFright += equippedWeaponStats.resistFright;
		resistHeadache += equippedWeaponStats.resistHeadache;
		resistBrainFart += equippedWeaponStats.resistBrainFart;
		resistArmCrushed += equippedWeaponStats.resistArmCrushed;
		resistWeakened += equippedWeaponStats.resistWeakened;
		resistBlasphemed += equippedWeaponStats.resistBlasphemed;
		damageLoweredPerSecond += equippedWeaponStats.itemDamagedLoweredPerSecond;
		damageIncreasedPerSecond += equippedWeaponStats.itemDamagedIncresedPerSecond;
		armCrushTimer -= equippedWeaponStats.decreaseArmCrushTimer;
		blasphemedTimer -= equippedWeaponStats.decreaseBlasphemedTimer;
		stunTimer -= equippedWeaponStats.lowerStunTimer;
		curseTimer -= equippedWeaponStats.lowerCurseDebuffSeconds;
		muffledTimer -= equippedWeaponStats.lowerMuffledDebuffSeconds;
		brainFartTimer -= equippedWeaponStats.lowerBrainFartDebuffSeconds;
		jumpHeight -= equippedWeaponStats.lowerJumpHeight;
			isEquippedWeapon = true;
				equippingWeapon = true;
			}
		}








	
	

		//make sure to run this function before unequipping item to reset stats.
		if(equippedWeapon != null && equipWeapon == false){
			if(equippingWeapon == true){
			isEquippedWeapon = false;
		HP -= equippedWeaponStats.HP;
		CD -= equippedWeaponStats.CD;
		GPRegen -= equippedWeaponStats.GPrate;
		fireBallDamage -= equippedWeaponStats.fireBallDamageIncreased;
		wrath -= equippedWeaponStats.increaseWrath;
		power -= equippedWeaponStats.itemPower;
		SwingSpeed -= equippedWeaponStats.itemSwingSpeed;
		AttackSpeed -= equippedWeaponStats.itemAttackSpeedIncrease;
		arcRange -= equippedWeaponStats.itemArcRange;
		charge -= equippedWeaponStats.itemChargeIncrease;
		knockback -= equippedWeaponStats.itemKnockback;
		forwardMomentum -= equippedWeaponStats.itemforwardMomentum;
		meleeCritChance -= equippedWeaponStats.itemMeleeCritChanceIncrease;
		meleeCritDamage -= equippedWeaponStats.increaseMeleeCritDamage;
		meleeSpeed -= equippedWeaponStats.increaseMeleeSpeed;
		maxMeleeDamage -= equippedWeaponStats.increaseMeleeMax;
		maxWeaponDamage -= equippedWeaponStats.increaseMaxWeaponDamage;
		awe -= equippedWeaponStats.increaseAwe;
		HPRegen -= equippedWeaponStats.itemHpRegain;
		HPRegen -= equippedWeaponStats.itemHpRegainIncrease;
		maxHp -= equippedWeaponStats.itemMaxHpIncrease;
		maxHp -= equippedWeaponStats.itemIncreaseBaseMaxHp;//double
		moveSpeed -= equippedWeaponStats.itemMoveSpeedIncrease;
		jumpHeight -= equippedWeaponStats.increaseJumpHeight;
		mercy -= equippedWeaponStats.increaseMercy;
		summonMaxHP -= equippedWeaponStats.increaseSummonMaxHP;
		summonMaxGP -= equippedWeaponStats.increaseSummonMaxGP;
		summonMindControl -= equippedWeaponStats.increaseSummonedMindControl;
		vengeance -= equippedWeaponStats.increaseVengeance;
		exodus -= equippedWeaponStats.increaseExodus;
		GPCostReduce -= equippedWeaponStats.itemGpCostReduce;
		GPDamage -= equippedWeaponStats.itemGpDamageIncrease;
		GPRegen -= equippedWeaponStats.increaseGPregeneration;
		GPRegen -= equippedWeaponStats.itemGpRegeneration;//double
		GPCritBonusDamage -= equippedWeaponStats.increaseGPCritBonusDamage;
		MaxGP -= equippedWeaponStats.maxGPincrease;
		GPResistance -= equippedWeaponStats.increaseGPresistance;
		MaxGP -= equippedWeaponStats.increaseMaxGP;//double
		GPCritDamage -= equippedWeaponStats.increaseGPcritDamage;
		defense -= equippedWeaponStats.itemDefense;
		defense -= equippedWeaponStats.itemDefenseIncrease; //double
		armorBonus -= equippedWeaponStats.increaseArmorBonus;
		resistWater -= equippedWeaponStats.itemWaterResist;
		bonusResistFire -= equippedWeaponStats.increaseBonusResistFire;
		bonusResistShadow -= equippedWeaponStats.increaseBonusResistShadow;
		resistLight -= equippedWeaponStats.resistLight;
		resistBlind -= equippedWeaponStats.resistBlind;
		resistMelted -= equippedWeaponStats.resistMelted;
		resistPoision -= equippedWeaponStats.resistPoision;
		resistSlow -= equippedWeaponStats.resistSlow;
		resistFright -= equippedWeaponStats.resistFright;
		resistHeadache -= equippedWeaponStats.resistHeadache;
		resistBrainFart -= equippedWeaponStats.resistBrainFart;
		resistArmCrushed -= equippedWeaponStats.resistArmCrushed;
		resistWeakened -= equippedWeaponStats.resistWeakened;
		resistBlasphemed -= equippedWeaponStats.resistBlasphemed;
		damageLoweredPerSecond -= equippedWeaponStats.itemDamagedLoweredPerSecond;
		damageIncreasedPerSecond -= equippedWeaponStats.itemDamagedIncresedPerSecond;
		armCrushTimer += equippedWeaponStats.decreaseArmCrushTimer;
		blasphemedTimer += equippedWeaponStats.decreaseBlasphemedTimer;
		stunTimer += equippedWeaponStats.lowerStunTimer;
		curseTimer += equippedWeaponStats.lowerCurseDebuffSeconds;
		muffledTimer += equippedWeaponStats.lowerMuffledDebuffSeconds;
		brainFartTimer += equippedWeaponStats.lowerBrainFartDebuffSeconds;
		jumpHeight += equippedWeaponStats.lowerJumpHeight;
			equippedWeapon = null;
				equippingWeapon = false;
			}
			//isEquippedWeapon = false;
		}
	
		if(equippedArmor != null && equipArmor == true){
			if(equippingArmor == false){
			HP += equippedArmorStats.HP;
			CD += equippedArmorStats.CD;
			GPRegen += equippedArmorStats.GPrate;
			fireBallDamage += equippedArmorStats.fireBallDamageIncreased;
			wrath += equippedArmorStats.increaseWrath;
			power += equippedArmorStats.itemPower;
			SwingSpeed += equippedArmorStats.itemSwingSpeed;
			AttackSpeed += equippedArmorStats.itemAttackSpeedIncrease;
			arcRange += equippedArmorStats.itemArcRange;
			charge += equippedArmorStats.itemChargeIncrease;
			knockback += equippedArmorStats.itemKnockback;
			forwardMomentum += equippedArmorStats.itemforwardMomentum;
			meleeCritChance += equippedArmorStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedArmorStats.increaseMeleeCritDamage;
			meleeSpeed += equippedArmorStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedArmorStats.increaseMeleeMax;
			maxWeaponDamage += equippedArmorStats.increaseMaxWeaponDamage;
			awe += equippedArmorStats.increaseAwe;
			HPRegen += equippedArmorStats.itemHpRegain;
			HPRegen += equippedArmorStats.itemHpRegainIncrease;
			maxHp += equippedArmorStats.itemMaxHpIncrease;
			maxHp += equippedArmorStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedArmorStats.itemMoveSpeedIncrease;
			jumpHeight += equippedArmorStats.increaseJumpHeight;
			mercy += equippedArmorStats.increaseMercy;
			summonMaxHP += equippedArmorStats.increaseSummonMaxHP;
			summonMaxGP += equippedArmorStats.increaseSummonMaxGP;
			summonMindControl += equippedArmorStats.increaseSummonedMindControl;
			vengeance += equippedArmorStats.increaseVengeance;
			exodus += equippedArmorStats.increaseExodus;
			GPCostReduce += equippedArmorStats.itemGpCostReduce;
			GPDamage += equippedArmorStats.itemGpDamageIncrease;
			GPRegen += equippedArmorStats.increaseGPregeneration;
			GPRegen += equippedArmorStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedArmorStats.increaseGPCritBonusDamage;
			MaxGP += equippedArmorStats.maxGPincrease;
			GPResistance += equippedArmorStats.increaseGPresistance;
			MaxGP += equippedArmorStats.increaseMaxGP;//double
			GPCritDamage += equippedArmorStats.increaseGPcritDamage;
			defense += equippedArmorStats.itemDefense;
			defense += equippedArmorStats.itemDefenseIncrease; //double
			armorBonus += equippedArmorStats.increaseArmorBonus;
			resistWater += equippedArmorStats.itemWaterResist;
			bonusResistFire += equippedArmorStats.increaseBonusResistFire;
			bonusResistShadow += equippedArmorStats.increaseBonusResistShadow;
			resistLight += equippedArmorStats.resistLight;
			resistBlind += equippedArmorStats.resistBlind;
			resistMelted += equippedArmorStats.resistMelted;
			resistPoision += equippedArmorStats.resistPoision;
			resistSlow += equippedArmorStats.resistSlow;
			resistFright += equippedArmorStats.resistFright;
			resistHeadache += equippedArmorStats.resistHeadache;
			resistBrainFart += equippedArmorStats.resistBrainFart;
			resistArmCrushed += equippedArmorStats.resistArmCrushed;
			resistWeakened += equippedArmorStats.resistWeakened;
			resistBlasphemed += equippedArmorStats.resistBlasphemed;
			damageLoweredPerSecond += equippedArmorStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedArmorStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedArmorStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedArmorStats.decreaseBlasphemedTimer;
			stunTimer -= equippedArmorStats.lowerStunTimer;
			curseTimer -= equippedArmorStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedArmorStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedArmorStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedArmorStats.lowerJumpHeight;
			isEquippedArmor = true;
				equippingArmor = true;
			}
		}
		
		
		
		
		
		
		
		
		
	
		
		//make sure to run this function before unequipping item to reset stats.
		if(equippedArmor != null && equipArmor == false){
			if(equippingArmor == true){
			HP -= equippedArmorStats.HP;
			CD -= equippedArmorStats.CD;
			GPRegen -= equippedArmorStats.GPrate;
			fireBallDamage -= equippedArmorStats.fireBallDamageIncreased;
			wrath -= equippedArmorStats.increaseWrath;
			power -= equippedArmorStats.itemPower;
			SwingSpeed -= equippedArmorStats.itemSwingSpeed;
			AttackSpeed -= equippedArmorStats.itemAttackSpeedIncrease;
			arcRange -= equippedArmorStats.itemArcRange;
			charge -= equippedArmorStats.itemChargeIncrease;
			knockback -= equippedArmorStats.itemKnockback;
			forwardMomentum -= equippedArmorStats.itemforwardMomentum;
			meleeCritChance -= equippedArmorStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedArmorStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedArmorStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedArmorStats.increaseMeleeMax;
			maxWeaponDamage -= equippedArmorStats.increaseMaxWeaponDamage;
			awe -= equippedArmorStats.increaseAwe;
			HPRegen -= equippedArmorStats.itemHpRegain;
			HPRegen -= equippedArmorStats.itemHpRegainIncrease;
			maxHp -= equippedArmorStats.itemMaxHpIncrease;
			maxHp -= equippedArmorStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedArmorStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedArmorStats.increaseJumpHeight;
			mercy -= equippedArmorStats.increaseMercy;
			summonMaxHP -= equippedArmorStats.increaseSummonMaxHP;
			summonMaxGP -= equippedArmorStats.increaseSummonMaxGP;
			summonMindControl -= equippedArmorStats.increaseSummonedMindControl;
			vengeance -= equippedArmorStats.increaseVengeance;
			exodus -= equippedArmorStats.increaseExodus;
			GPCostReduce -= equippedArmorStats.itemGpCostReduce;
			GPDamage -= equippedArmorStats.itemGpDamageIncrease;
			GPRegen -= equippedArmorStats.increaseGPregeneration;
			GPRegen -= equippedArmorStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedArmorStats.increaseGPCritBonusDamage;
			MaxGP -= equippedArmorStats.maxGPincrease;
			GPResistance -= equippedArmorStats.increaseGPresistance;
			MaxGP -= equippedArmorStats.increaseMaxGP;//double
			GPCritDamage -= equippedArmorStats.increaseGPcritDamage;
			defense -= equippedArmorStats.itemDefense;
			defense -= equippedArmorStats.itemDefenseIncrease; //double
			armorBonus -= equippedArmorStats.increaseArmorBonus;
			resistWater -= equippedArmorStats.itemWaterResist;
			bonusResistFire -= equippedArmorStats.increaseBonusResistFire;
			bonusResistShadow -= equippedArmorStats.increaseBonusResistShadow;
			resistLight -= equippedArmorStats.resistLight;
			resistBlind -= equippedArmorStats.resistBlind;
			resistMelted -= equippedArmorStats.resistMelted;
			resistPoision -= equippedArmorStats.resistPoision;
			resistSlow -= equippedArmorStats.resistSlow;
			resistFright -= equippedArmorStats.resistFright;
			resistHeadache -= equippedArmorStats.resistHeadache;
			resistBrainFart -= equippedArmorStats.resistBrainFart;
			resistArmCrushed -= equippedArmorStats.resistArmCrushed;
			resistWeakened -= equippedArmorStats.resistWeakened;
			resistBlasphemed -= equippedArmorStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedArmorStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedArmorStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedArmorStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedArmorStats.decreaseBlasphemedTimer;
			stunTimer += equippedArmorStats.lowerStunTimer;
			curseTimer += equippedArmorStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedArmorStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedArmorStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedArmorStats.lowerJumpHeight;
			equippedArmor = null;
			isEquippedArmor = false;
			equippingArmor = false;
			}

		}
	
		if(equippedHead != null && equipHead == true){
			if(equippingHead == false){
			HP += equippedHeadStats.HP;
			CD += equippedHeadStats.CD;
			GPRegen += equippedHeadStats.GPrate;
			fireBallDamage += equippedHeadStats.fireBallDamageIncreased;
			wrath += equippedHeadStats.increaseWrath;
			power += equippedHeadStats.itemPower;
			SwingSpeed += equippedHeadStats.itemSwingSpeed;
			AttackSpeed += equippedHeadStats.itemAttackSpeedIncrease;
			arcRange += equippedHeadStats.itemArcRange;
			charge += equippedHeadStats.itemChargeIncrease;
			knockback += equippedHeadStats.itemKnockback;
			forwardMomentum += equippedHeadStats.itemforwardMomentum;
			meleeCritChance += equippedHeadStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedHeadStats.increaseMeleeCritDamage;
			meleeSpeed += equippedHeadStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedHeadStats.increaseMeleeMax;
			maxWeaponDamage += equippedHeadStats.increaseMaxWeaponDamage;
			awe += equippedHeadStats.increaseAwe;
			HPRegen += equippedHeadStats.itemHpRegain;
			HPRegen += equippedHeadStats.itemHpRegainIncrease;
			maxHp += equippedHeadStats.itemMaxHpIncrease;
			maxHp += equippedHeadStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedHeadStats.itemMoveSpeedIncrease;
			jumpHeight += equippedHeadStats.increaseJumpHeight;
			mercy += equippedHeadStats.increaseMercy;
			summonMaxHP += equippedHeadStats.increaseSummonMaxHP;
			summonMaxGP += equippedHeadStats.increaseSummonMaxGP;
			summonMindControl += equippedHeadStats.increaseSummonedMindControl;
			vengeance += equippedHeadStats.increaseVengeance;
			exodus += equippedHeadStats.increaseExodus;
			GPCostReduce += equippedHeadStats.itemGpCostReduce;
			GPDamage += equippedHeadStats.itemGpDamageIncrease;
			GPRegen += equippedHeadStats.increaseGPregeneration;
			GPRegen += equippedHeadStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedHeadStats.increaseGPCritBonusDamage;
			MaxGP += equippedHeadStats.maxGPincrease;
			GPResistance += equippedHeadStats.increaseGPresistance;
			MaxGP += equippedHeadStats.increaseMaxGP;//double
			GPCritDamage += equippedHeadStats.increaseGPcritDamage;
			defense += equippedHeadStats.itemDefense;
			defense += equippedHeadStats.itemDefenseIncrease; //double
			armorBonus += equippedHeadStats.increaseArmorBonus;
			resistWater += equippedHeadStats.itemWaterResist;
			bonusResistFire += equippedHeadStats.increaseBonusResistFire;
			bonusResistShadow += equippedHeadStats.increaseBonusResistShadow;
			resistLight += equippedHeadStats.resistLight;
			resistBlind += equippedHeadStats.resistBlind;
			resistMelted += equippedHeadStats.resistMelted;
			resistPoision += equippedHeadStats.resistPoision;
			resistSlow += equippedHeadStats.resistSlow;
			resistFright += equippedHeadStats.resistFright;
			resistHeadache += equippedHeadStats.resistHeadache;
			resistBrainFart += equippedHeadStats.resistBrainFart;
			resistArmCrushed += equippedHeadStats.resistArmCrushed;
			resistWeakened += equippedHeadStats.resistWeakened;
			resistBlasphemed += equippedHeadStats.resistBlasphemed;
			damageLoweredPerSecond += equippedHeadStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedHeadStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedHeadStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedHeadStats.decreaseBlasphemedTimer;
			stunTimer -= equippedHeadStats.lowerStunTimer;
			curseTimer -= equippedHeadStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedHeadStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedHeadStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedHeadStats.lowerJumpHeight;
			isEquippedHead = true;
				equippingHead = true;
			}
		}
		
		
		
		
		
		
		
		
		
	
		
		//make sure to run this function before unequipping item to reset stats.
		if(equippedHead != null && equipHead == false){
			if(equippingHead == true){
			HP -= equippedHeadStats.HP;
			CD -= equippedHeadStats.CD;
			GPRegen -= equippedHeadStats.GPrate;
			fireBallDamage -= equippedHeadStats.fireBallDamageIncreased;
			wrath -= equippedHeadStats.increaseWrath;
			power -= equippedHeadStats.itemPower;
			SwingSpeed -= equippedHeadStats.itemSwingSpeed;
			AttackSpeed -= equippedHeadStats.itemAttackSpeedIncrease;
			arcRange -= equippedHeadStats.itemArcRange;
			charge -= equippedHeadStats.itemChargeIncrease;
			knockback -= equippedHeadStats.itemKnockback;
			forwardMomentum -= equippedHeadStats.itemforwardMomentum;
			meleeCritChance -= equippedHeadStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedHeadStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedHeadStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedHeadStats.increaseMeleeMax;
			maxWeaponDamage -= equippedHeadStats.increaseMaxWeaponDamage;
			awe -= equippedHeadStats.increaseAwe;
			HPRegen -= equippedHeadStats.itemHpRegain;
			HPRegen -= equippedHeadStats.itemHpRegainIncrease;
			maxHp -= equippedHeadStats.itemMaxHpIncrease;
			maxHp -= equippedHeadStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedHeadStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedHeadStats.increaseJumpHeight;
			mercy -= equippedHeadStats.increaseMercy;
			summonMaxHP -= equippedHeadStats.increaseSummonMaxHP;
			summonMaxGP -= equippedHeadStats.increaseSummonMaxGP;
			summonMindControl -= equippedHeadStats.increaseSummonedMindControl;
			vengeance -= equippedHeadStats.increaseVengeance;
			exodus -= equippedHeadStats.increaseExodus;
			GPCostReduce -= equippedHeadStats.itemGpCostReduce;
			GPDamage -= equippedHeadStats.itemGpDamageIncrease;
			GPRegen -= equippedHeadStats.increaseGPregeneration;
			GPRegen -= equippedHeadStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedHeadStats.increaseGPCritBonusDamage;
			MaxGP -= equippedHeadStats.maxGPincrease;
			GPResistance -= equippedHeadStats.increaseGPresistance;
			MaxGP -= equippedHeadStats.increaseMaxGP;//double
			GPCritDamage -= equippedHeadStats.increaseGPcritDamage;
			defense -= equippedHeadStats.itemDefense;
			defense -= equippedHeadStats.itemDefenseIncrease; //double
			armorBonus -= equippedHeadStats.increaseArmorBonus;
			resistWater -= equippedHeadStats.itemWaterResist;
			bonusResistFire -= equippedHeadStats.increaseBonusResistFire;
			bonusResistShadow -= equippedHeadStats.increaseBonusResistShadow;
			resistLight -= equippedHeadStats.resistLight;
			resistBlind -= equippedHeadStats.resistBlind;
			resistMelted -= equippedHeadStats.resistMelted;
			resistPoision -= equippedHeadStats.resistPoision;
			resistSlow -= equippedHeadStats.resistSlow;
			resistFright -= equippedHeadStats.resistFright;
			resistHeadache -= equippedHeadStats.resistHeadache;
			resistBrainFart -= equippedHeadStats.resistBrainFart;
			resistArmCrushed -= equippedHeadStats.resistArmCrushed;
			resistWeakened -= equippedHeadStats.resistWeakened;
			resistBlasphemed -= equippedHeadStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedHeadStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedHeadStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedHeadStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedHeadStats.decreaseBlasphemedTimer;
			stunTimer += equippedHeadStats.lowerStunTimer;
			curseTimer += equippedHeadStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedHeadStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedHeadStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedHeadStats.lowerJumpHeight;
			equippedHead = null;
			isEquippedHead = false;
				equippingHead = false;
			}
		}
	
		if(equippedWaste != null && equipWaste == true){
			if(equippingWaste == false){
			HP += equippedWaistStats.HP;
			CD += equippedWaistStats.CD;
			GPRegen += equippedWaistStats.GPrate;
			fireBallDamage += equippedWaistStats.fireBallDamageIncreased;
			wrath += equippedWaistStats.increaseWrath;
			power += equippedWaistStats.itemPower;
			SwingSpeed += equippedWaistStats.itemSwingSpeed;
			AttackSpeed += equippedWaistStats.itemAttackSpeedIncrease;
			arcRange += equippedWaistStats.itemArcRange;
			charge += equippedWaistStats.itemChargeIncrease;
			knockback += equippedWaistStats.itemKnockback;
			forwardMomentum += equippedWaistStats.itemforwardMomentum;
			meleeCritChance += equippedWaistStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedWaistStats.increaseMeleeCritDamage;
			meleeSpeed += equippedWaistStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedWaistStats.increaseMeleeMax;
			maxWeaponDamage += equippedWaistStats.increaseMaxWeaponDamage;
			awe += equippedWaistStats.increaseAwe;
			HPRegen += equippedWaistStats.itemHpRegain;
			HPRegen += equippedWaistStats.itemHpRegainIncrease;
			maxHp += equippedWaistStats.itemMaxHpIncrease;
			maxHp += equippedWaistStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedWaistStats.itemMoveSpeedIncrease;
			jumpHeight += equippedWaistStats.increaseJumpHeight;
			mercy += equippedWaistStats.increaseMercy;
			summonMaxHP += equippedWaistStats.increaseSummonMaxHP;
			summonMaxGP += equippedWaistStats.increaseSummonMaxGP;
			summonMindControl += equippedWaistStats.increaseSummonedMindControl;
			vengeance += equippedWaistStats.increaseVengeance;
			exodus += equippedWaistStats.increaseExodus;
			GPCostReduce += equippedWaistStats.itemGpCostReduce;
			GPDamage += equippedWaistStats.itemGpDamageIncrease;
			GPRegen += equippedWaistStats.increaseGPregeneration;
			GPRegen += equippedWaistStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedWaistStats.increaseGPCritBonusDamage;
			MaxGP += equippedWaistStats.maxGPincrease;
			GPResistance += equippedWaistStats.increaseGPresistance;
			MaxGP += equippedWaistStats.increaseMaxGP;//double
			GPCritDamage += equippedWaistStats.increaseGPcritDamage;
			defense += equippedWaistStats.itemDefense;
			defense += equippedWaistStats.itemDefenseIncrease; //double
			armorBonus += equippedWaistStats.increaseArmorBonus;
			resistWater += equippedWaistStats.itemWaterResist;
			bonusResistFire += equippedWaistStats.increaseBonusResistFire;
			bonusResistShadow += equippedWaistStats.increaseBonusResistShadow;
			resistLight += equippedWaistStats.resistLight;
			resistBlind += equippedWaistStats.resistBlind;
			resistMelted += equippedWaistStats.resistMelted;
			resistPoision += equippedWaistStats.resistPoision;
			resistSlow += equippedWaistStats.resistSlow;
			resistFright += equippedWaistStats.resistFright;
			resistHeadache += equippedWaistStats.resistHeadache;
			resistBrainFart += equippedWaistStats.resistBrainFart;
			resistArmCrushed += equippedWaistStats.resistArmCrushed;
			resistWeakened += equippedWaistStats.resistWeakened;
			resistBlasphemed += equippedWaistStats.resistBlasphemed;
			damageLoweredPerSecond += equippedWaistStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedWaistStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedWaistStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedWaistStats.decreaseBlasphemedTimer;
			stunTimer -= equippedWaistStats.lowerStunTimer;
			curseTimer -= equippedWaistStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedWaistStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedWaistStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedWaistStats.lowerJumpHeight;
			isEquippedWaste = true;
				equippingWaste = true;
			}
		}
		
		
		
		
		
		
		
		
		

		//make sure to run this function before unequipping item to reset stats.
		if(equippedWaste != null && equipWaste == false){
			if(equippingWaste == true)
			{
			HP -= equippedWaistStats.HP;
			CD -= equippedWaistStats.CD;
			GPRegen -= equippedWaistStats.GPrate;
			fireBallDamage -= equippedWaistStats.fireBallDamageIncreased;
			wrath -= equippedWaistStats.increaseWrath;
			power -= equippedWaistStats.itemPower;
			SwingSpeed -= equippedWaistStats.itemSwingSpeed;
			AttackSpeed -= equippedWaistStats.itemAttackSpeedIncrease;
			arcRange -= equippedWaistStats.itemArcRange;
			charge -= equippedWaistStats.itemChargeIncrease;
			knockback -= equippedWaistStats.itemKnockback;
			forwardMomentum -= equippedWaistStats.itemforwardMomentum;
			meleeCritChance -= equippedWaistStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedWaistStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedWaistStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedWaistStats.increaseMeleeMax;
			maxWeaponDamage -= equippedWaistStats.increaseMaxWeaponDamage;
			awe -= equippedWaistStats.increaseAwe;
			HPRegen -= equippedWaistStats.itemHpRegain;
			HPRegen -= equippedWaistStats.itemHpRegainIncrease;
			maxHp -= equippedWaistStats.itemMaxHpIncrease;
			maxHp -= equippedWaistStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedWaistStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedWaistStats.increaseJumpHeight;
			mercy -= equippedWaistStats.increaseMercy;
			summonMaxHP -= equippedWaistStats.increaseSummonMaxHP;
			summonMaxGP -= equippedWaistStats.increaseSummonMaxGP;
			summonMindControl -= equippedWaistStats.increaseSummonedMindControl;
			vengeance -= equippedWaistStats.increaseVengeance;
			exodus -= equippedWaistStats.increaseExodus;
			GPCostReduce -= equippedWaistStats.itemGpCostReduce;
			GPDamage -= equippedWaistStats.itemGpDamageIncrease;
			GPRegen -= equippedWaistStats.increaseGPregeneration;
			GPRegen -= equippedWaistStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedWaistStats.increaseGPCritBonusDamage;
			MaxGP -= equippedWaistStats.maxGPincrease;
			GPResistance -= equippedWaistStats.increaseGPresistance;
			MaxGP -= equippedWaistStats.increaseMaxGP;//double
			GPCritDamage -= equippedWaistStats.increaseGPcritDamage;
			defense -= equippedWaistStats.itemDefense;
			defense -= equippedWaistStats.itemDefenseIncrease; //double
			armorBonus -= equippedWaistStats.increaseArmorBonus;
			resistWater -= equippedWaistStats.itemWaterResist;
			bonusResistFire -= equippedWaistStats.increaseBonusResistFire;
			bonusResistShadow -= equippedWaistStats.increaseBonusResistShadow;
			resistLight -= equippedWaistStats.resistLight;
			resistBlind -= equippedWaistStats.resistBlind;
			resistMelted -= equippedWaistStats.resistMelted;
			resistPoision -= equippedWaistStats.resistPoision;
			resistSlow -= equippedWaistStats.resistSlow;
			resistFright -= equippedWaistStats.resistFright;
			resistHeadache -= equippedWaistStats.resistHeadache;
			resistBrainFart -= equippedWaistStats.resistBrainFart;
			resistArmCrushed -= equippedWaistStats.resistArmCrushed;
			resistWeakened -= equippedWaistStats.resistWeakened;
			resistBlasphemed -= equippedWaistStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedWaistStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedWaistStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedWaistStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedWaistStats.decreaseBlasphemedTimer;
			stunTimer += equippedWaistStats.lowerStunTimer;
			curseTimer += equippedWaistStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedWaistStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedWaistStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedWaistStats.lowerJumpHeight;
			equippedWaste = null;
				equippingWaste = false;
				isEquippedWaste = false;
			}
		}
		if(equippedFeet != null && equipFeet == true){
			if(equippingFeet == false){
			HP += equippedFeetStats.HP;
			CD += equippedFeetStats.CD;
			GPRegen += equippedFeetStats.GPrate;
			fireBallDamage += equippedFeetStats.fireBallDamageIncreased;
			wrath += equippedFeetStats.increaseWrath;
			power += equippedFeetStats.itemPower;
			SwingSpeed += equippedFeetStats.itemSwingSpeed;
			AttackSpeed += equippedFeetStats.itemAttackSpeedIncrease;
			arcRange += equippedFeetStats.itemArcRange;
			charge += equippedFeetStats.itemChargeIncrease;
			knockback += equippedFeetStats.itemKnockback;
			forwardMomentum += equippedFeetStats.itemforwardMomentum;
			meleeCritChance += equippedFeetStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedFeetStats.increaseMeleeCritDamage;
			meleeSpeed += equippedFeetStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedFeetStats.increaseMeleeMax;
			maxWeaponDamage += equippedFeetStats.increaseMaxWeaponDamage;
			awe += equippedFeetStats.increaseAwe;
			HPRegen += equippedFeetStats.itemHpRegain;
			HPRegen += equippedFeetStats.itemHpRegainIncrease;
			maxHp += equippedFeetStats.itemMaxHpIncrease;
			maxHp += equippedFeetStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedFeetStats.itemMoveSpeedIncrease;
			jumpHeight += equippedFeetStats.increaseJumpHeight;
			mercy += equippedFeetStats.increaseMercy;
			summonMaxHP += equippedFeetStats.increaseSummonMaxHP;
			summonMaxGP += equippedFeetStats.increaseSummonMaxGP;
			summonMindControl += equippedFeetStats.increaseSummonedMindControl;
			vengeance += equippedFeetStats.increaseVengeance;
			exodus += equippedFeetStats.increaseExodus;
			GPCostReduce += equippedFeetStats.itemGpCostReduce;
			GPDamage += equippedFeetStats.itemGpDamageIncrease;
			GPRegen += equippedFeetStats.increaseGPregeneration;
			GPRegen += equippedFeetStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedFeetStats.increaseGPCritBonusDamage;
			MaxGP += equippedFeetStats.maxGPincrease;
			GPResistance += equippedFeetStats.increaseGPresistance;
			MaxGP += equippedFeetStats.increaseMaxGP;//double
			GPCritDamage += equippedFeetStats.increaseGPcritDamage;
			defense += equippedFeetStats.itemDefense;
			defense += equippedFeetStats.itemDefenseIncrease; //double
			armorBonus += equippedFeetStats.increaseArmorBonus;
			resistWater += equippedFeetStats.itemWaterResist;
			bonusResistFire += equippedFeetStats.increaseBonusResistFire;
			bonusResistShadow += equippedFeetStats.increaseBonusResistShadow;
			resistLight += equippedFeetStats.resistLight;
			resistBlind += equippedFeetStats.resistBlind;
			resistMelted += equippedFeetStats.resistMelted;
			resistPoision += equippedFeetStats.resistPoision;
			resistSlow += equippedFeetStats.resistSlow;
			resistFright += equippedFeetStats.resistFright;
			resistHeadache += equippedFeetStats.resistHeadache;
			resistBrainFart += equippedFeetStats.resistBrainFart;
			resistArmCrushed += equippedFeetStats.resistArmCrushed;
			resistWeakened += equippedFeetStats.resistWeakened;
			resistBlasphemed += equippedFeetStats.resistBlasphemed;
			damageLoweredPerSecond += equippedFeetStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedFeetStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedFeetStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedFeetStats.decreaseBlasphemedTimer;
			stunTimer -= equippedFeetStats.lowerStunTimer;
			curseTimer -= equippedFeetStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedFeetStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedFeetStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedFeetStats.lowerJumpHeight;
			isEquippedFeet = true;
				equippingFeet = true;
			}
		}
		
		
		
		
		
		
		
		
		
		//make sure to run this function before unequipping item to reset stats.
		if(equippedFeet != null && equipFeet == false){
			if(equippingFeet == true){
			HP -= equippedFeetStats.HP;
			CD -= equippedFeetStats.CD;
			GPRegen -= equippedFeetStats.GPrate;
			fireBallDamage -= equippedFeetStats.fireBallDamageIncreased;
			wrath -= equippedFeetStats.increaseWrath;
			power -= equippedFeetStats.itemPower;
			SwingSpeed -= equippedFeetStats.itemSwingSpeed;
			AttackSpeed -= equippedFeetStats.itemAttackSpeedIncrease;
			arcRange -= equippedFeetStats.itemArcRange;
			charge -= equippedFeetStats.itemChargeIncrease;
			knockback -= equippedFeetStats.itemKnockback;
			forwardMomentum -= equippedFeetStats.itemforwardMomentum;
			meleeCritChance -= equippedFeetStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedFeetStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedFeetStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedFeetStats.increaseMeleeMax;
			maxWeaponDamage -= equippedFeetStats.increaseMaxWeaponDamage;
			awe -= equippedFeetStats.increaseAwe;
			HPRegen -= equippedFeetStats.itemHpRegain;
			HPRegen -= equippedFeetStats.itemHpRegainIncrease;
			maxHp -= equippedFeetStats.itemMaxHpIncrease;
			maxHp -= equippedFeetStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedFeetStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedFeetStats.increaseJumpHeight;
			mercy -= equippedFeetStats.increaseMercy;
			summonMaxHP -= equippedFeetStats.increaseSummonMaxHP;
			summonMaxGP -= equippedFeetStats.increaseSummonMaxGP;
			summonMindControl -= equippedFeetStats.increaseSummonedMindControl;
			vengeance -= equippedFeetStats.increaseVengeance;
			exodus -= equippedFeetStats.increaseExodus;
			GPCostReduce -= equippedFeetStats.itemGpCostReduce;
			GPDamage -= equippedFeetStats.itemGpDamageIncrease;
			GPRegen -= equippedFeetStats.increaseGPregeneration;
			GPRegen -= equippedFeetStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedFeetStats.increaseGPCritBonusDamage;
			MaxGP -= equippedFeetStats.maxGPincrease;
			GPResistance -= equippedFeetStats.increaseGPresistance;
			MaxGP -= equippedFeetStats.increaseMaxGP;//double
			GPCritDamage -= equippedFeetStats.increaseGPcritDamage;
			defense -= equippedFeetStats.itemDefense;
			defense -= equippedFeetStats.itemDefenseIncrease; //double
			armorBonus -= equippedFeetStats.increaseArmorBonus;
			resistWater -= equippedFeetStats.itemWaterResist;
			bonusResistFire -= equippedFeetStats.increaseBonusResistFire;
			bonusResistShadow -= equippedFeetStats.increaseBonusResistShadow;
			resistLight -= equippedFeetStats.resistLight;
			resistBlind -= equippedFeetStats.resistBlind;
			resistMelted -= equippedFeetStats.resistMelted;
			resistPoision -= equippedFeetStats.resistPoision;
			resistSlow -= equippedFeetStats.resistSlow;
			resistFright -= equippedFeetStats.resistFright;
			resistHeadache -= equippedFeetStats.resistHeadache;
			resistBrainFart -= equippedFeetStats.resistBrainFart;
			resistArmCrushed -= equippedFeetStats.resistArmCrushed;
			resistWeakened -= equippedFeetStats.resistWeakened;
			resistBlasphemed -= equippedFeetStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedFeetStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedFeetStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedFeetStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedFeetStats.decreaseBlasphemedTimer;
			stunTimer += equippedFeetStats.lowerStunTimer;
			curseTimer += equippedFeetStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedFeetStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedFeetStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedFeetStats.lowerJumpHeight;
			equippedFeet = null;
			isEquippedFeet = false;
				equippingFeet = false;
			}
		}
		if(equippedHands != null && equipHands == true){
			if(equippingHands == false){
			HP += equippedHandsStats.HP;
			CD += equippedHandsStats.CD;
			GPRegen += equippedHandsStats.GPrate;
			fireBallDamage += equippedHandsStats.fireBallDamageIncreased;
			wrath += equippedHandsStats.increaseWrath;
			power += equippedHandsStats.itemPower;
			SwingSpeed += equippedHandsStats.itemSwingSpeed;
			AttackSpeed += equippedHandsStats.itemAttackSpeedIncrease;
			arcRange += equippedHandsStats.itemArcRange;
			charge += equippedHandsStats.itemChargeIncrease;
			knockback += equippedHandsStats.itemKnockback;
			forwardMomentum += equippedHandsStats.itemforwardMomentum;
			meleeCritChance += equippedHandsStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedHandsStats.increaseMeleeCritDamage;
			meleeSpeed += equippedHandsStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedHandsStats.increaseMeleeMax;
			maxWeaponDamage += equippedHandsStats.increaseMaxWeaponDamage;
			awe += equippedHandsStats.increaseAwe;
			HPRegen += equippedHandsStats.itemHpRegain;
			HPRegen += equippedHandsStats.itemHpRegainIncrease;
			maxHp += equippedHandsStats.itemMaxHpIncrease;
			maxHp += equippedHandsStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedHandsStats.itemMoveSpeedIncrease;
			jumpHeight += equippedHandsStats.increaseJumpHeight;
			mercy += equippedHandsStats.increaseMercy;
			summonMaxHP += equippedHandsStats.increaseSummonMaxHP;
			summonMaxGP += equippedHandsStats.increaseSummonMaxGP;
			summonMindControl += equippedHandsStats.increaseSummonedMindControl;
			vengeance += equippedHandsStats.increaseVengeance;
			exodus += equippedHandsStats.increaseExodus;
			GPCostReduce += equippedHandsStats.itemGpCostReduce;
			GPDamage += equippedHandsStats.itemGpDamageIncrease;
			GPRegen += equippedHandsStats.increaseGPregeneration;
			GPRegen += equippedHandsStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedHandsStats.increaseGPCritBonusDamage;
			MaxGP += equippedHandsStats.maxGPincrease;
			GPResistance += equippedHandsStats.increaseGPresistance;
			MaxGP += equippedHandsStats.increaseMaxGP;//double
			GPCritDamage += equippedHandsStats.increaseGPcritDamage;
			defense += equippedHandsStats.itemDefense;
			defense += equippedHandsStats.itemDefenseIncrease; //double
			armorBonus += equippedHandsStats.increaseArmorBonus;
			resistWater += equippedHandsStats.itemWaterResist;
			bonusResistFire += equippedHandsStats.increaseBonusResistFire;
			bonusResistShadow += equippedHandsStats.increaseBonusResistShadow;
			resistLight += equippedHandsStats.resistLight;
			resistBlind += equippedHandsStats.resistBlind;
			resistMelted += equippedHandsStats.resistMelted;
			resistPoision += equippedHandsStats.resistPoision;
			resistSlow += equippedHandsStats.resistSlow;
			resistFright += equippedHandsStats.resistFright;
			resistHeadache += equippedHandsStats.resistHeadache;
			resistBrainFart += equippedHandsStats.resistBrainFart;
			resistArmCrushed += equippedHandsStats.resistArmCrushed;
			resistWeakened += equippedHandsStats.resistWeakened;
			resistBlasphemed += equippedHandsStats.resistBlasphemed;
			damageLoweredPerSecond += equippedHandsStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedHandsStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedHandsStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedHandsStats.decreaseBlasphemedTimer;
			stunTimer -= equippedHandsStats.lowerStunTimer;
			curseTimer -= equippedHandsStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedHandsStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedHandsStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedHandsStats.lowerJumpHeight;
			isEquippedHands = true;
				equippingHands = true;
			}
		}
		
		
		
		
		
		
		
		
		

		//make sure to run this function before unequipping item to reset stats.
		if(equippedHands != null && equipHands == false){
			if(equippingHands == true){
			HP -= equippedHandsStats.HP;
			CD -= equippedHandsStats.CD;
			GPRegen -= equippedHandsStats.GPrate;
			fireBallDamage -= equippedHandsStats.fireBallDamageIncreased;
			wrath -= equippedHandsStats.increaseWrath;
			power -= equippedHandsStats.itemPower;
			SwingSpeed -= equippedHandsStats.itemSwingSpeed;
			AttackSpeed -= equippedHandsStats.itemAttackSpeedIncrease;
			arcRange -= equippedHandsStats.itemArcRange;
			charge -= equippedHandsStats.itemChargeIncrease;
			knockback -= equippedHandsStats.itemKnockback;
			forwardMomentum -= equippedHandsStats.itemforwardMomentum;
			meleeCritChance -= equippedHandsStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedHandsStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedHandsStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedHandsStats.increaseMeleeMax;
			maxWeaponDamage -= equippedHandsStats.increaseMaxWeaponDamage;
			awe -= equippedHandsStats.increaseAwe;
			HPRegen -= equippedHandsStats.itemHpRegain;
			HPRegen -= equippedHandsStats.itemHpRegainIncrease;
			maxHp -= equippedHandsStats.itemMaxHpIncrease;
			maxHp -= equippedHandsStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedHandsStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedHandsStats.increaseJumpHeight;
			mercy -= equippedHandsStats.increaseMercy;
			summonMaxHP -= equippedHandsStats.increaseSummonMaxHP;
			summonMaxGP -= equippedHandsStats.increaseSummonMaxGP;
			summonMindControl -= equippedHandsStats.increaseSummonedMindControl;
			vengeance -= equippedHandsStats.increaseVengeance;
			exodus -= equippedHandsStats.increaseExodus;
			GPCostReduce -= equippedHandsStats.itemGpCostReduce;
			GPDamage -= equippedHandsStats.itemGpDamageIncrease;
			GPRegen -= equippedHandsStats.increaseGPregeneration;
			GPRegen -= equippedHandsStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedHandsStats.increaseGPCritBonusDamage;
			MaxGP -= equippedHandsStats.maxGPincrease;
			GPResistance -= equippedHandsStats.increaseGPresistance;
			MaxGP -= equippedHandsStats.increaseMaxGP;//double
			GPCritDamage -= equippedHandsStats.increaseGPcritDamage;
			defense -= equippedHandsStats.itemDefense;
			defense -= equippedHandsStats.itemDefenseIncrease; //double
			armorBonus -= equippedHandsStats.increaseArmorBonus;
			resistWater -= equippedHandsStats.itemWaterResist;
			bonusResistFire -= equippedHandsStats.increaseBonusResistFire;
			bonusResistShadow -= equippedHandsStats.increaseBonusResistShadow;
			resistLight -= equippedHandsStats.resistLight;
			resistBlind -= equippedHandsStats.resistBlind;
			resistMelted -= equippedHandsStats.resistMelted;
			resistPoision -= equippedHandsStats.resistPoision;
			resistSlow -= equippedHandsStats.resistSlow;
			resistFright -= equippedHandsStats.resistFright;
			resistHeadache -= equippedHandsStats.resistHeadache;
			resistBrainFart -= equippedHandsStats.resistBrainFart;
			resistArmCrushed -= equippedHandsStats.resistArmCrushed;
			resistWeakened -= equippedHandsStats.resistWeakened;
			resistBlasphemed -= equippedHandsStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedHandsStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedHandsStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedHandsStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedHandsStats.decreaseBlasphemedTimer;
			stunTimer += equippedHandsStats.lowerStunTimer;
			curseTimer += equippedHandsStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedHandsStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedHandsStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedHandsStats.lowerJumpHeight;
			equippedHands = null;
			isEquippedHands = false;
				equippingHands = false;
			}
		}
		if(equippedRing1 != null && equippedRing1 == true){
			if(equippingRing1 == false){
			HP += equippedRing1Stats.HP;
			CD += equippedRing1Stats.CD;
			GPRegen += equippedRing1Stats.GPrate;
			fireBallDamage += equippedRing1Stats.fireBallDamageIncreased;
			wrath += equippedRing1Stats.increaseWrath;
			power += equippedRing1Stats.itemPower;
			SwingSpeed += equippedRing1Stats.itemSwingSpeed;
			AttackSpeed += equippedRing1Stats.itemAttackSpeedIncrease;
			arcRange += equippedRing1Stats.itemArcRange;
			charge += equippedRing1Stats.itemChargeIncrease;
			knockback += equippedRing1Stats.itemKnockback;
			forwardMomentum += equippedRing1Stats.itemforwardMomentum;
			meleeCritChance += equippedRing1Stats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedRing1Stats.increaseMeleeCritDamage;
			meleeSpeed += equippedRing1Stats.increaseMeleeSpeed;
			maxMeleeDamage += equippedRing1Stats.increaseMeleeMax;
			maxWeaponDamage += equippedRing1Stats.increaseMaxWeaponDamage;
			awe += equippedRing1Stats.increaseAwe;
			HPRegen += equippedRing1Stats.itemHpRegain;
			HPRegen += equippedRing1Stats.itemHpRegainIncrease;
			maxHp += equippedRing1Stats.itemMaxHpIncrease;
			maxHp += equippedRing1Stats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedRing1Stats.itemMoveSpeedIncrease;
			jumpHeight += equippedRing1Stats.increaseJumpHeight;
			mercy += equippedRing1Stats.increaseMercy;
			summonMaxHP += equippedRing1Stats.increaseSummonMaxHP;
			summonMaxGP += equippedRing1Stats.increaseSummonMaxGP;
			summonMindControl += equippedRing1Stats.increaseSummonedMindControl;
			vengeance += equippedRing1Stats.increaseVengeance;
			exodus += equippedRing1Stats.increaseExodus;
			GPCostReduce += equippedRing1Stats.itemGpCostReduce;
			GPDamage += equippedRing1Stats.itemGpDamageIncrease;
			GPRegen += equippedRing1Stats.increaseGPregeneration;
			GPRegen += equippedRing1Stats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedRing1Stats.increaseGPCritBonusDamage;
			MaxGP += equippedRing1Stats.maxGPincrease;
			GPResistance += equippedRing1Stats.increaseGPresistance;
			MaxGP += equippedRing1Stats.increaseMaxGP;//double
			GPCritDamage += equippedRing1Stats.increaseGPcritDamage;
			defense += equippedRing1Stats.itemDefense;
			defense += equippedRing1Stats.itemDefenseIncrease; //double
			armorBonus += equippedRing1Stats.increaseArmorBonus;
			resistWater += equippedRing1Stats.itemWaterResist;
			bonusResistFire += equippedRing1Stats.increaseBonusResistFire;
			bonusResistShadow += equippedRing1Stats.increaseBonusResistShadow;
			resistLight += equippedRing1Stats.resistLight;
			resistBlind += equippedRing1Stats.resistBlind;
			resistMelted += equippedRing1Stats.resistMelted;
			resistPoision += equippedRing1Stats.resistPoision;
			resistSlow += equippedRing1Stats.resistSlow;
			resistFright += equippedRing1Stats.resistFright;
			resistHeadache += equippedRing1Stats.resistHeadache;
			resistBrainFart += equippedRing1Stats.resistBrainFart;
			resistArmCrushed += equippedRing1Stats.resistArmCrushed;
			resistWeakened += equippedRing1Stats.resistWeakened;
			resistBlasphemed += equippedRing1Stats.resistBlasphemed;
			damageLoweredPerSecond += equippedRing1Stats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedRing1Stats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedRing1Stats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedRing1Stats.decreaseBlasphemedTimer;
			stunTimer -= equippedRing1Stats.lowerStunTimer;
			curseTimer -= equippedRing1Stats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedRing1Stats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedRing1Stats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedRing1Stats.lowerJumpHeight;
			isEquippedRing1 = true;
				equippingRing1 = true;
			}
		}
		
		
		
		
		
		
		
		
		
		//make sure to run this function before unequipping item to reset stats.
		if(equippedRing1 != null && equipRing1 == false){
			if(equippingRing1 = true){
			HP -= equippedRing1Stats.HP;
			CD -= equippedRing1Stats.CD;
			GPRegen -= equippedRing1Stats.GPrate;
			fireBallDamage -= equippedRing1Stats.fireBallDamageIncreased;
			wrath -= equippedRing1Stats.increaseWrath;
			power -= equippedRing1Stats.itemPower;
			SwingSpeed -= equippedRing1Stats.itemSwingSpeed;
			AttackSpeed -= equippedRing1Stats.itemAttackSpeedIncrease;
			arcRange -= equippedRing1Stats.itemArcRange;
			charge -= equippedRing1Stats.itemChargeIncrease;
			knockback -= equippedRing1Stats.itemKnockback;
			forwardMomentum -= equippedRing1Stats.itemforwardMomentum;
			meleeCritChance -= equippedRing1Stats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedRing1Stats.increaseMeleeCritDamage;
			meleeSpeed -= equippedRing1Stats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedRing1Stats.increaseMeleeMax;
			maxWeaponDamage -= equippedRing1Stats.increaseMaxWeaponDamage;
			awe -= equippedRing1Stats.increaseAwe;
			HPRegen -= equippedRing1Stats.itemHpRegain;
			HPRegen -= equippedRing1Stats.itemHpRegainIncrease;
			maxHp -= equippedRing1Stats.itemMaxHpIncrease;
			maxHp -= equippedRing1Stats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedRing1Stats.itemMoveSpeedIncrease;
			jumpHeight -= equippedRing1Stats.increaseJumpHeight;
			mercy -= equippedRing1Stats.increaseMercy;
			summonMaxHP -= equippedRing1Stats.increaseSummonMaxHP;
			summonMaxGP -= equippedRing1Stats.increaseSummonMaxGP;
			summonMindControl -= equippedRing1Stats.increaseSummonedMindControl;
			vengeance -= equippedRing1Stats.increaseVengeance;
			exodus -= equippedRing1Stats.increaseExodus;
			GPCostReduce -= equippedRing1Stats.itemGpCostReduce;
			GPDamage -= equippedRing1Stats.itemGpDamageIncrease;
			GPRegen -= equippedRing1Stats.increaseGPregeneration;
			GPRegen -= equippedRing1Stats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedRing1Stats.increaseGPCritBonusDamage;
			MaxGP -= equippedRing1Stats.maxGPincrease;
			GPResistance -= equippedRing1Stats.increaseGPresistance;
			MaxGP -= equippedRing1Stats.increaseMaxGP;//double
			GPCritDamage -= equippedRing1Stats.increaseGPcritDamage;
			defense -= equippedRing1Stats.itemDefense;
			defense -= equippedRing1Stats.itemDefenseIncrease; //double
			armorBonus -= equippedRing1Stats.increaseArmorBonus;
			resistWater -= equippedRing1Stats.itemWaterResist;
			bonusResistFire -= equippedRing1Stats.increaseBonusResistFire;
			bonusResistShadow -= equippedRing1Stats.increaseBonusResistShadow;
			resistLight -= equippedRing1Stats.resistLight;
			resistBlind -= equippedRing1Stats.resistBlind;
			resistMelted -= equippedRing1Stats.resistMelted;
			resistPoision -= equippedRing1Stats.resistPoision;
			resistSlow -= equippedRing1Stats.resistSlow;
			resistFright -= equippedRing1Stats.resistFright;
			resistHeadache -= equippedRing1Stats.resistHeadache;
			resistBrainFart -= equippedRing1Stats.resistBrainFart;
			resistArmCrushed -= equippedRing1Stats.resistArmCrushed;
			resistWeakened -= equippedRing1Stats.resistWeakened;
			resistBlasphemed -= equippedRing1Stats.resistBlasphemed;
			damageLoweredPerSecond -= equippedRing1Stats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedRing1Stats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedRing1Stats.decreaseArmCrushTimer;
			blasphemedTimer += equippedRing1Stats.decreaseBlasphemedTimer;
			stunTimer += equippedRing1Stats.lowerStunTimer;
			curseTimer += equippedRing1Stats.lowerCurseDebuffSeconds;
			muffledTimer += equippedRing1Stats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedRing1Stats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedRing1Stats.lowerJumpHeight;
			equippedRing1 = null;
			isEquippedRing1 = false;
				equippingRing1 =false;
			}
		}
			if(equippedRing2 != null && equipRing2 == true){
			if(equippingRing2 == false){
			HP += equippedRing2Stats.HP;
				CD += equippedRing2Stats.CD;
				GPRegen += equippedRing2Stats.GPrate;
				fireBallDamage += equippedRing2Stats.fireBallDamageIncreased;
				wrath += equippedRing2Stats.increaseWrath;
				power += equippedRing2Stats.itemPower;
				SwingSpeed += equippedRing2Stats.itemSwingSpeed;
				AttackSpeed += equippedRing2Stats.itemAttackSpeedIncrease;
				arcRange += equippedRing2Stats.itemArcRange;
				charge += equippedRing2Stats.itemChargeIncrease;
				knockback += equippedRing2Stats.itemKnockback;
				forwardMomentum += equippedRing2Stats.itemforwardMomentum;
				meleeCritChance += equippedRing2Stats.itemMeleeCritChanceIncrease;
				meleeCritDamage += equippedRing2Stats.increaseMeleeCritDamage;
				meleeSpeed += equippedRing2Stats.increaseMeleeSpeed;
				maxMeleeDamage += equippedRing2Stats.increaseMeleeMax;
				maxWeaponDamage += equippedRing2Stats.increaseMaxWeaponDamage;
				awe += equippedRing2Stats.increaseAwe;
				HPRegen += equippedRing2Stats.itemHpRegain;
				HPRegen += equippedRing2Stats.itemHpRegainIncrease;
				maxHp += equippedRing2Stats.itemMaxHpIncrease;
				maxHp += equippedRing2Stats.itemIncreaseBaseMaxHp;//double
				moveSpeed += equippedRing2Stats.itemMoveSpeedIncrease;
				jumpHeight += equippedRing2Stats.increaseJumpHeight;
				mercy += equippedRing2Stats.increaseMercy;
				summonMaxHP += equippedRing2Stats.increaseSummonMaxHP;
				summonMaxGP += equippedRing2Stats.increaseSummonMaxGP;
				summonMindControl += equippedRing2Stats.increaseSummonedMindControl;
				vengeance += equippedRing2Stats.increaseVengeance;
				exodus += equippedRing2Stats.increaseExodus;
				GPCostReduce += equippedRing2Stats.itemGpCostReduce;
				GPDamage += equippedRing2Stats.itemGpDamageIncrease;
				GPRegen += equippedRing2Stats.increaseGPregeneration;
				GPRegen += equippedRing2Stats.itemGpRegeneration;//double
				GPCritBonusDamage += equippedRing2Stats.increaseGPCritBonusDamage;
				MaxGP += equippedRing2Stats.maxGPincrease;
				GPResistance += equippedRing2Stats.increaseGPresistance;
				MaxGP += equippedRing2Stats.increaseMaxGP;//double
				GPCritDamage += equippedRing2Stats.increaseGPcritDamage;
				defense += equippedRing2Stats.itemDefense;
				defense += equippedRing2Stats.itemDefenseIncrease; //double
				armorBonus += equippedRing2Stats.increaseArmorBonus;
				resistWater += equippedRing2Stats.itemWaterResist;
				bonusResistFire += equippedRing2Stats.increaseBonusResistFire;
				bonusResistShadow += equippedRing2Stats.increaseBonusResistShadow;
				resistLight += equippedRing2Stats.resistLight;
				resistBlind += equippedRing2Stats.resistBlind;
				resistMelted += equippedRing2Stats.resistMelted;
				resistPoision += equippedRing2Stats.resistPoision;
				resistSlow += equippedRing2Stats.resistSlow;
				resistFright += equippedRing2Stats.resistFright;
				resistHeadache += equippedRing2Stats.resistHeadache;
				resistBrainFart += equippedRing2Stats.resistBrainFart;
				resistArmCrushed += equippedRing2Stats.resistArmCrushed;
				resistWeakened += equippedRing2Stats.resistWeakened;
				resistBlasphemed += equippedRing2Stats.resistBlasphemed;
				damageLoweredPerSecond += equippedRing2Stats.itemDamagedLoweredPerSecond;
				damageIncreasedPerSecond += equippedRing2Stats.itemDamagedIncresedPerSecond;
				armCrushTimer -= equippedRing2Stats.decreaseArmCrushTimer;
				blasphemedTimer -= equippedRing2Stats.decreaseBlasphemedTimer;
				stunTimer -= equippedRing2Stats.lowerStunTimer;
				curseTimer -= equippedRing2Stats.lowerCurseDebuffSeconds;
				muffledTimer -= equippedRing2Stats.lowerMuffledDebuffSeconds;
				brainFartTimer -= equippedRing2Stats.lowerBrainFartDebuffSeconds;
				jumpHeight -= equippedRing2Stats.lowerJumpHeight;
				equippingRing2 = true;
				isEquippedRing2 = true;
			}
		}
			
			
			
			
			
			
			
			
			
			
			//make sure to run this function before unequipping item to reset stats.
			if(equippedRing2 != null && equipRing2 == false){
				if(equippingRing2 == true){
				HP -= equippedRing2Stats.HP;
				CD -= equippedRing2Stats.CD;
				GPRegen -= equippedRing2Stats.GPrate;
				fireBallDamage -= equippedRing2Stats.fireBallDamageIncreased;
				wrath -= equippedRing2Stats.increaseWrath;
				power -= equippedRing2Stats.itemPower;
				SwingSpeed -= equippedRing2Stats.itemSwingSpeed;
				AttackSpeed -= equippedRing2Stats.itemAttackSpeedIncrease;
				arcRange -= equippedRing2Stats.itemArcRange;
				charge -= equippedRing2Stats.itemChargeIncrease;
				knockback -= equippedRing2Stats.itemKnockback;
				forwardMomentum -= equippedRing2Stats.itemforwardMomentum;
				meleeCritChance -= equippedRing2Stats.itemMeleeCritChanceIncrease;
				meleeCritDamage -= equippedRing2Stats.increaseMeleeCritDamage;
				meleeSpeed -= equippedRing2Stats.increaseMeleeSpeed;
				maxMeleeDamage -= equippedRing2Stats.increaseMeleeMax;
				maxWeaponDamage -= equippedRing2Stats.increaseMaxWeaponDamage;
				awe -= equippedRing2Stats.increaseAwe;
				HPRegen -= equippedRing2Stats.itemHpRegain;
				HPRegen -= equippedRing2Stats.itemHpRegainIncrease;
				maxHp -= equippedRing2Stats.itemMaxHpIncrease;
				maxHp -= equippedRing2Stats.itemIncreaseBaseMaxHp;//double
				moveSpeed -= equippedRing2Stats.itemMoveSpeedIncrease;
				jumpHeight -= equippedRing2Stats.increaseJumpHeight;
				mercy -= equippedRing2Stats.increaseMercy;
				summonMaxHP -= equippedRing2Stats.increaseSummonMaxHP;
				summonMaxGP -= equippedRing2Stats.increaseSummonMaxGP;
				summonMindControl -= equippedRing2Stats.increaseSummonedMindControl;
				vengeance -= equippedRing2Stats.increaseVengeance;
				exodus -= equippedRing2Stats.increaseExodus;
				GPCostReduce -= equippedRing2Stats.itemGpCostReduce;
				GPDamage -= equippedRing2Stats.itemGpDamageIncrease;
				GPRegen -= equippedRing2Stats.increaseGPregeneration;
				GPRegen -= equippedRing2Stats.itemGpRegeneration;//double
				GPCritBonusDamage -= equippedRing2Stats.increaseGPCritBonusDamage;
				MaxGP -= equippedRing2Stats.maxGPincrease;
				GPResistance -= equippedRing2Stats.increaseGPresistance;
				MaxGP -= equippedRing2Stats.increaseMaxGP;//double
				GPCritDamage -= equippedRing2Stats.increaseGPcritDamage;
				defense -= equippedRing2Stats.itemDefense;
				defense -= equippedRing2Stats.itemDefenseIncrease; //double
				armorBonus -= equippedRing2Stats.increaseArmorBonus;
				resistWater -= equippedRing2Stats.itemWaterResist;
				bonusResistFire -= equippedRing2Stats.increaseBonusResistFire;
				bonusResistShadow -= equippedRing2Stats.increaseBonusResistShadow;
				resistLight -= equippedRing2Stats.resistLight;
				resistBlind -= equippedRing2Stats.resistBlind;
				resistMelted -= equippedRing2Stats.resistMelted;
				resistPoision -= equippedRing2Stats.resistPoision;
				resistSlow -= equippedRing2Stats.resistSlow;
				resistFright -= equippedRing2Stats.resistFright;
				resistHeadache -= equippedRing2Stats.resistHeadache;
				resistBrainFart -= equippedRing2Stats.resistBrainFart;
				resistArmCrushed -= equippedRing2Stats.resistArmCrushed;
				resistWeakened -= equippedRing2Stats.resistWeakened;
				resistBlasphemed -= equippedRing2Stats.resistBlasphemed;
				damageLoweredPerSecond -= equippedRing2Stats.itemDamagedLoweredPerSecond;
				damageIncreasedPerSecond -= equippedRing2Stats.itemDamagedIncresedPerSecond;
				armCrushTimer += equippedRing2Stats.decreaseArmCrushTimer;
				blasphemedTimer += equippedRing2Stats.decreaseBlasphemedTimer;
				stunTimer += equippedRing2Stats.lowerStunTimer;
				curseTimer += equippedRing2Stats.lowerCurseDebuffSeconds;
				muffledTimer += equippedRing2Stats.lowerMuffledDebuffSeconds;
				brainFartTimer += equippedRing2Stats.lowerBrainFartDebuffSeconds;
				jumpHeight += equippedRing2Stats.lowerJumpHeight;
			equippedRing2 = null;	
			isEquippedRing2 = false;
				equippingRing2 = false;
			}
			}
		if(equippedNeck != null && equipNeck == true){
			if(equippingNeck == false){
			HP += equippedNeckStats.HP;
			CD += equippedNeckStats.CD;
			GPRegen += equippedNeckStats.GPrate;
			fireBallDamage += equippedNeckStats.fireBallDamageIncreased;
			wrath += equippedNeckStats.increaseWrath;
			power += equippedNeckStats.itemPower;
			SwingSpeed += equippedNeckStats.itemSwingSpeed;
			AttackSpeed += equippedNeckStats.itemAttackSpeedIncrease;
			arcRange += equippedNeckStats.itemArcRange;
			charge += equippedNeckStats.itemChargeIncrease;
			knockback += equippedNeckStats.itemKnockback;
			forwardMomentum += equippedNeckStats.itemforwardMomentum;
			meleeCritChance += equippedNeckStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedNeckStats.increaseMeleeCritDamage;
			meleeSpeed += equippedNeckStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedNeckStats.increaseMeleeMax;
			maxWeaponDamage += equippedNeckStats.increaseMaxWeaponDamage;
			awe += equippedNeckStats.increaseAwe;
			HPRegen += equippedNeckStats.itemHpRegain;
			HPRegen += equippedNeckStats.itemHpRegainIncrease;
			maxHp += equippedNeckStats.itemMaxHpIncrease;
			maxHp += equippedNeckStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedNeckStats.itemMoveSpeedIncrease;
			jumpHeight += equippedNeckStats.increaseJumpHeight;
			mercy += equippedNeckStats.increaseMercy;
			summonMaxHP += equippedNeckStats.increaseSummonMaxHP;
			summonMaxGP += equippedNeckStats.increaseSummonMaxGP;
			summonMindControl += equippedNeckStats.increaseSummonedMindControl;
			vengeance += equippedNeckStats.increaseVengeance;
			exodus += equippedNeckStats.increaseExodus;
			GPCostReduce += equippedNeckStats.itemGpCostReduce;
			GPDamage += equippedNeckStats.itemGpDamageIncrease;
			GPRegen += equippedNeckStats.increaseGPregeneration;
			GPRegen += equippedNeckStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedNeckStats.increaseGPCritBonusDamage;
			MaxGP += equippedNeckStats.maxGPincrease;
			GPResistance += equippedNeckStats.increaseGPresistance;
			MaxGP += equippedNeckStats.increaseMaxGP;//double
			GPCritDamage += equippedNeckStats.increaseGPcritDamage;
			defense += equippedNeckStats.itemDefense;
			defense += equippedNeckStats.itemDefenseIncrease; //double
			armorBonus += equippedNeckStats.increaseArmorBonus;
			resistWater += equippedNeckStats.itemWaterResist;
			bonusResistFire += equippedNeckStats.increaseBonusResistFire;
			bonusResistShadow += equippedNeckStats.increaseBonusResistShadow;
			resistLight += equippedNeckStats.resistLight;
			resistBlind += equippedNeckStats.resistBlind;
			resistMelted += equippedNeckStats.resistMelted;
			resistPoision += equippedNeckStats.resistPoision;
			resistSlow += equippedNeckStats.resistSlow;
			resistFright += equippedNeckStats.resistFright;
			resistHeadache += equippedNeckStats.resistHeadache;
			resistBrainFart += equippedNeckStats.resistBrainFart;
			resistArmCrushed += equippedNeckStats.resistArmCrushed;
			resistWeakened += equippedNeckStats.resistWeakened;
			resistBlasphemed += equippedNeckStats.resistBlasphemed;
			damageLoweredPerSecond += equippedNeckStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedNeckStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedNeckStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedNeckStats.decreaseBlasphemedTimer;
			stunTimer -= equippedNeckStats.lowerStunTimer;
			curseTimer -= equippedNeckStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedNeckStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedNeckStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedNeckStats.lowerJumpHeight;
			isEquippedNeck = true;
				equippingNeck = true;
			}
		}
		
		
		
		
		
		
		
		
		

		//make sure to run this function before unequipping item to reset stats.
		if(equippedNeck != null && equipNeck == false){
			if(equippingNeck == true){
			HP -= equippedNeckStats.HP;
			CD -= equippedNeckStats.CD;
			GPRegen -= equippedNeckStats.GPrate;
			fireBallDamage -= equippedNeckStats.fireBallDamageIncreased;
			wrath -= equippedNeckStats.increaseWrath;
			power -= equippedNeckStats.itemPower;
			SwingSpeed -= equippedNeckStats.itemSwingSpeed;
			AttackSpeed -= equippedNeckStats.itemAttackSpeedIncrease;
			arcRange -= equippedNeckStats.itemArcRange;
			charge -= equippedNeckStats.itemChargeIncrease;
			knockback -= equippedNeckStats.itemKnockback;
			forwardMomentum -= equippedNeckStats.itemforwardMomentum;
			meleeCritChance -= equippedNeckStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedNeckStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedNeckStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedNeckStats.increaseMeleeMax;
			maxWeaponDamage -= equippedNeckStats.increaseMaxWeaponDamage;
			awe -= equippedNeckStats.increaseAwe;
			HPRegen -= equippedNeckStats.itemHpRegain;
			HPRegen -= equippedNeckStats.itemHpRegainIncrease;
			maxHp -= equippedNeckStats.itemMaxHpIncrease;
			maxHp -= equippedNeckStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedNeckStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedNeckStats.increaseJumpHeight;
			mercy -= equippedNeckStats.increaseMercy;
			summonMaxHP -= equippedNeckStats.increaseSummonMaxHP;
			summonMaxGP -= equippedNeckStats.increaseSummonMaxGP;
			summonMindControl -= equippedNeckStats.increaseSummonedMindControl;
			vengeance -= equippedNeckStats.increaseVengeance;
			exodus -= equippedNeckStats.increaseExodus;
			GPCostReduce -= equippedNeckStats.itemGpCostReduce;
			GPDamage -= equippedNeckStats.itemGpDamageIncrease;
			GPRegen -= equippedNeckStats.increaseGPregeneration;
			GPRegen -= equippedNeckStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedNeckStats.increaseGPCritBonusDamage;
			MaxGP -= equippedNeckStats.maxGPincrease;
			GPResistance -= equippedNeckStats.increaseGPresistance;
			MaxGP -= equippedNeckStats.increaseMaxGP;//double
			GPCritDamage -= equippedNeckStats.increaseGPcritDamage;
			defense -= equippedNeckStats.itemDefense;
			defense -= equippedNeckStats.itemDefenseIncrease; //double
			armorBonus -= equippedNeckStats.increaseArmorBonus;
			resistWater -= equippedNeckStats.itemWaterResist;
			bonusResistFire -= equippedNeckStats.increaseBonusResistFire;
			bonusResistShadow -= equippedNeckStats.increaseBonusResistShadow;
			resistLight -= equippedNeckStats.resistLight;
			resistBlind -= equippedNeckStats.resistBlind;
			resistMelted -= equippedNeckStats.resistMelted;
			resistPoision -= equippedNeckStats.resistPoision;
			resistSlow -= equippedNeckStats.resistSlow;
			resistFright -= equippedNeckStats.resistFright;
			resistHeadache -= equippedNeckStats.resistHeadache;
			resistBrainFart -= equippedNeckStats.resistBrainFart;
			resistArmCrushed -= equippedNeckStats.resistArmCrushed;
			resistWeakened -= equippedNeckStats.resistWeakened;
			resistBlasphemed -= equippedNeckStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedNeckStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedNeckStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedNeckStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedNeckStats.decreaseBlasphemedTimer;
			stunTimer += equippedNeckStats.lowerStunTimer;
			curseTimer += equippedNeckStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedNeckStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedNeckStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedNeckStats.lowerJumpHeight;
			equippedNeck = null;
			isEquippedNeck = false;
				equippingNeck = false;
			}
		}
		if(equippedShield != null && equipShield == true){
			if(equippingShield == false){
			HP += equippedShieldStats.HP;
			CD += equippedShieldStats.CD;
			GPRegen += equippedShieldStats.GPrate;
			fireBallDamage += equippedShieldStats.fireBallDamageIncreased;
			wrath += equippedShieldStats.increaseWrath;
			power += equippedShieldStats.itemPower;
			SwingSpeed += equippedShieldStats.itemSwingSpeed;
			AttackSpeed += equippedShieldStats.itemAttackSpeedIncrease;
			arcRange += equippedShieldStats.itemArcRange;
			charge += equippedShieldStats.itemChargeIncrease;
			knockback += equippedShieldStats.itemKnockback;
			forwardMomentum += equippedShieldStats.itemforwardMomentum;
			meleeCritChance += equippedShieldStats.itemMeleeCritChanceIncrease;
			meleeCritDamage += equippedShieldStats.increaseMeleeCritDamage;
			meleeSpeed += equippedShieldStats.increaseMeleeSpeed;
			maxMeleeDamage += equippedShieldStats.increaseMeleeMax;
			maxWeaponDamage += equippedShieldStats.increaseMaxWeaponDamage;
			awe += equippedShieldStats.increaseAwe;
			HPRegen += equippedShieldStats.itemHpRegain;
			HPRegen += equippedShieldStats.itemHpRegainIncrease;
			maxHp += equippedShieldStats.itemMaxHpIncrease;
			maxHp += equippedShieldStats.itemIncreaseBaseMaxHp;//double
			moveSpeed += equippedShieldStats.itemMoveSpeedIncrease;
			jumpHeight += equippedShieldStats.increaseJumpHeight;
			mercy += equippedShieldStats.increaseMercy;
			summonMaxHP += equippedShieldStats.increaseSummonMaxHP;
			summonMaxGP += equippedShieldStats.increaseSummonMaxGP;
			summonMindControl += equippedShieldStats.increaseSummonedMindControl;
			vengeance += equippedShieldStats.increaseVengeance;
			exodus += equippedShieldStats.increaseExodus;
			GPCostReduce += equippedShieldStats.itemGpCostReduce;
			GPDamage += equippedShieldStats.itemGpDamageIncrease;
			GPRegen += equippedShieldStats.increaseGPregeneration;
			GPRegen += equippedShieldStats.itemGpRegeneration;//double
			GPCritBonusDamage += equippedShieldStats.increaseGPCritBonusDamage;
			MaxGP += equippedShieldStats.maxGPincrease;
			GPResistance += equippedShieldStats.increaseGPresistance;
			MaxGP += equippedShieldStats.increaseMaxGP;//double
			GPCritDamage += equippedShieldStats.increaseGPcritDamage;
			defense += equippedShieldStats.itemDefense;
			defense += equippedShieldStats.itemDefenseIncrease; //double
			armorBonus += equippedShieldStats.increaseArmorBonus;
			resistWater += equippedShieldStats.itemWaterResist;
			bonusResistFire += equippedShieldStats.increaseBonusResistFire;
			bonusResistShadow += equippedShieldStats.increaseBonusResistShadow;
			resistLight += equippedShieldStats.resistLight;
			resistBlind += equippedShieldStats.resistBlind;
			resistMelted += equippedShieldStats.resistMelted;
			resistPoision += equippedShieldStats.resistPoision;
			resistSlow += equippedShieldStats.resistSlow;
			resistFright += equippedShieldStats.resistFright;
			resistHeadache += equippedShieldStats.resistHeadache;
			resistBrainFart += equippedShieldStats.resistBrainFart;
			resistArmCrushed += equippedShieldStats.resistArmCrushed;
			resistWeakened += equippedShieldStats.resistWeakened;
			resistBlasphemed += equippedShieldStats.resistBlasphemed;
			damageLoweredPerSecond += equippedShieldStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond += equippedShieldStats.itemDamagedIncresedPerSecond;
			armCrushTimer -= equippedShieldStats.decreaseArmCrushTimer;
			blasphemedTimer -= equippedShieldStats.decreaseBlasphemedTimer;
			stunTimer -= equippedShieldStats.lowerStunTimer;
			curseTimer -= equippedShieldStats.lowerCurseDebuffSeconds;
			muffledTimer -= equippedShieldStats.lowerMuffledDebuffSeconds;
			brainFartTimer -= equippedShieldStats.lowerBrainFartDebuffSeconds;
			jumpHeight -= equippedShieldStats.lowerJumpHeight;
			isEquippedShield = true;
				equippingShield = true;
			}
		}
		
		
		
		
		
		
		
		
		

		//make sure to run this function before unequipping item to reset stats.
	if(equippedShield != null && equipShield == false){
			if(equippingShield == true){
			HP -= equippedShieldStats.HP;
			CD -= equippedShieldStats.CD;
			GPRegen -= equippedShieldStats.GPrate;
			fireBallDamage -= equippedShieldStats.fireBallDamageIncreased;
			wrath -= equippedShieldStats.increaseWrath;
			power -= equippedShieldStats.itemPower;
			SwingSpeed -= equippedShieldStats.itemSwingSpeed;
			AttackSpeed -= equippedShieldStats.itemAttackSpeedIncrease;
			arcRange -= equippedShieldStats.itemArcRange;
			charge -= equippedShieldStats.itemChargeIncrease;
			knockback -= equippedShieldStats.itemKnockback;
			forwardMomentum -= equippedShieldStats.itemforwardMomentum;
			meleeCritChance -= equippedShieldStats.itemMeleeCritChanceIncrease;
			meleeCritDamage -= equippedShieldStats.increaseMeleeCritDamage;
			meleeSpeed -= equippedShieldStats.increaseMeleeSpeed;
			maxMeleeDamage -= equippedShieldStats.increaseMeleeMax;
			maxWeaponDamage -= equippedShieldStats.increaseMaxWeaponDamage;
			awe -= equippedShieldStats.increaseAwe;
			HPRegen -= equippedShieldStats.itemHpRegain;
			HPRegen -= equippedShieldStats.itemHpRegainIncrease;
			maxHp -= equippedShieldStats.itemMaxHpIncrease;
			maxHp -= equippedShieldStats.itemIncreaseBaseMaxHp;//double
			moveSpeed -= equippedShieldStats.itemMoveSpeedIncrease;
			jumpHeight -= equippedShieldStats.increaseJumpHeight;
			mercy -= equippedShieldStats.increaseMercy;
			summonMaxHP -= equippedShieldStats.increaseSummonMaxHP;
			summonMaxGP -= equippedShieldStats.increaseSummonMaxGP;
			summonMindControl -= equippedShieldStats.increaseSummonedMindControl;
			vengeance -= equippedShieldStats.increaseVengeance;
			exodus -= equippedShieldStats.increaseExodus;
			GPCostReduce -= equippedShieldStats.itemGpCostReduce;
			GPDamage -= equippedShieldStats.itemGpDamageIncrease;
			GPRegen -= equippedShieldStats.increaseGPregeneration;
			GPRegen -= equippedShieldStats.itemGpRegeneration;//double
			GPCritBonusDamage -= equippedShieldStats.increaseGPCritBonusDamage;
			MaxGP -= equippedShieldStats.maxGPincrease;
			GPResistance -= equippedShieldStats.increaseGPresistance;
			MaxGP -= equippedShieldStats.increaseMaxGP;//double
			GPCritDamage -= equippedShieldStats.increaseGPcritDamage;
			defense -= equippedShieldStats.itemDefense;
			defense -= equippedShieldStats.itemDefenseIncrease; //double
			armorBonus -= equippedShieldStats.increaseArmorBonus;
			resistWater -= equippedShieldStats.itemWaterResist;
			bonusResistFire -= equippedShieldStats.increaseBonusResistFire;
			bonusResistShadow -= equippedShieldStats.increaseBonusResistShadow;
			resistLight -= equippedShieldStats.resistLight;
			resistBlind -= equippedShieldStats.resistBlind;
			resistMelted -= equippedShieldStats.resistMelted;
			resistPoision -= equippedShieldStats.resistPoision;
			resistSlow -= equippedShieldStats.resistSlow;
			resistFright -= equippedShieldStats.resistFright;
			resistHeadache -= equippedShieldStats.resistHeadache;
			resistBrainFart -= equippedShieldStats.resistBrainFart;
			resistArmCrushed -= equippedShieldStats.resistArmCrushed;
			resistWeakened -= equippedShieldStats.resistWeakened;
			resistBlasphemed -= equippedShieldStats.resistBlasphemed;
			damageLoweredPerSecond -= equippedShieldStats.itemDamagedLoweredPerSecond;
			damageIncreasedPerSecond -= equippedShieldStats.itemDamagedIncresedPerSecond;
			armCrushTimer += equippedShieldStats.decreaseArmCrushTimer;
			blasphemedTimer += equippedShieldStats.decreaseBlasphemedTimer;
			stunTimer += equippedShieldStats.lowerStunTimer;
			curseTimer += equippedShieldStats.lowerCurseDebuffSeconds;
			muffledTimer += equippedShieldStats.lowerMuffledDebuffSeconds;
			brainFartTimer += equippedShieldStats.lowerBrainFartDebuffSeconds;
			jumpHeight += equippedShieldStats.lowerJumpHeight;
			equippedShield = null;
			isEquippedShield = false;
				equippingShield = false;
			}
		}


	}
}
