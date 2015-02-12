using UnityEngine;
using System.Collections;

public class EvilBadStats : MonoBehaviour {


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
	public ItemStats equippedItemStats;





	// Use this for initialization


	void OnEquipped(){
		HP += equippedItemStats.HP;
		CD += equippedItemStats.CD;
		GPRegen += equippedItemStats.GPrate;
		fireBallDamage += equippedItemStats.fireBallDamageIncreased;
		wrath += equippedItemStats.increaseWrath;
		power += equippedItemStats.itemPower;
		SwingSpeed += equippedItemStats.itemSwingSpeed;
		AttackSpeed += equippedItemStats.itemAttackSpeedIncrease;
		arcRange += equippedItemStats.itemArcRange;
		charge += equippedItemStats.itemChargeIncrease;
		knockback += equippedItemStats.itemKnockback;
		forwardMomentum += equippedItemStats.itemforwardMomentum;
		meleeCritChance += equippedItemStats.itemMeleeCritChanceIncrease;
		meleeCritDamage += equippedItemStats.increaseMeleeCritDamage;
		meleeSpeed += equippedItemStats.increaseMeleeSpeed;
		maxMeleeDamage += equippedItemStats.increaseMeleeMax;
		maxWeaponDamage += equippedItemStats.increaseMaxWeaponDamage;
		awe += equippedItemStats.increaseAwe;
		HPRegen += equippedItemStats.itemHpRegain;
		HPRegen += equippedItemStats.itemHpRegainIncrease;
		maxHp += equippedItemStats.itemMaxHpIncrease;
		maxHp += equippedItemStats.itemIncreaseBaseMaxHp;//double
		moveSpeed += equippedItemStats.itemMoveSpeedIncrease;
		jumpHeight += equippedItemStats.increaseJumpHeight;
		mercy += equippedItemStats.increaseMercy;
		summonMaxHP += equippedItemStats.increaseSummonMaxHP;
		summonMaxGP += equippedItemStats.increaseSummonMaxGP;
		summonMindControl += equippedItemStats.increaseSummonedMindControl;
		vengeance += equippedItemStats.increaseVengeance;
		exodus += equippedItemStats.increaseExodus;
		GPCostReduce += equippedItemStats.itemGpCostReduce;
		GPDamage += equippedItemStats.itemGpDamageIncrease;
		GPRegen += equippedItemStats.increaseGPregeneration;
		GPRegen += equippedItemStats.itemGpRegeneration;//double
		GPCritBonusDamage += equippedItemStats.increaseGPCritBonusDamage;
		MaxGP += equippedItemStats.maxGPincrease;
		GPResistance += equippedItemStats.increaseGPresistance;
		MaxGP += equippedItemStats.increaseMaxGP;//double
		GPCritDamage += equippedItemStats.increaseGPcritDamage;
		defense += equippedItemStats.itemDefense;
		defense += equippedItemStats.itemDefenseIncrease; //double
		armorBonus += equippedItemStats.increaseArmorBonus;
		resistWater += equippedItemStats.itemWaterResist;
		bonusResistFire += equippedItemStats.increaseBonusResistFire;
		bonusResistShadow += equippedItemStats.increaseBonusResistShadow;
		resistLight += equippedItemStats.resistLight;
		resistBlind += equippedItemStats.resistBlind;
		resistMelted += equippedItemStats.resistMelted;
		resistPoision += equippedItemStats.resistPoision;
		resistSlow += equippedItemStats.resistSlow;
		resistFright += equippedItemStats.resistFright;
		resistHeadache += equippedItemStats.resistHeadache;
		resistBrainFart += equippedItemStats.resistBrainFart;
		resistArmCrushed += equippedItemStats.resistArmCrushed;
		resistWeakened += equippedItemStats.resistWeakened;
		resistBlasphemed += equippedItemStats.resistBlasphemed;
		damageLoweredPerSecond += equippedItemStats.itemDamagedLoweredPerSecond;
		damageIncreasedPerSecond += equippedItemStats.itemDamagedIncresedPerSecond;
		armCrushTimer -= equippedItemStats.decreaseArmCrushTimer;
		blasphemedTimer -= equippedItemStats.decreaseBlasphemedTimer;
		stunTimer -= equippedItemStats.lowerStunTimer;
		curseTimer -= equippedItemStats.lowerCurseDebuffSeconds;
		muffledTimer -= equippedItemStats.lowerMuffledDebuffSeconds;
		brainFartTimer -= equippedItemStats.lowerBrainFartDebuffSeconds;
		jumpHeight -= equippedItemStats.lowerJumpHeight;
	







	
	}
	void OnUnEquipped(){ //make sure to run this function before unequipping item to reset stats.
		HP -= equippedItemStats.HP;
		CD -= equippedItemStats.CD;
		GPRegen -= equippedItemStats.GPrate;
		fireBallDamage -= equippedItemStats.fireBallDamageIncreased;
		wrath -= equippedItemStats.increaseWrath;
		power -= equippedItemStats.itemPower;
		SwingSpeed -= equippedItemStats.itemSwingSpeed;
		AttackSpeed -= equippedItemStats.itemAttackSpeedIncrease;
		arcRange -= equippedItemStats.itemArcRange;
		charge -= equippedItemStats.itemChargeIncrease;
		knockback -= equippedItemStats.itemKnockback;
		forwardMomentum -= equippedItemStats.itemforwardMomentum;
		meleeCritChance -= equippedItemStats.itemMeleeCritChanceIncrease;
		meleeCritDamage -= equippedItemStats.increaseMeleeCritDamage;
		meleeSpeed -= equippedItemStats.increaseMeleeSpeed;
		maxMeleeDamage -= equippedItemStats.increaseMeleeMax;
		maxWeaponDamage -= equippedItemStats.increaseMaxWeaponDamage;
		awe -= equippedItemStats.increaseAwe;
		HPRegen -= equippedItemStats.itemHpRegain;
		HPRegen -= equippedItemStats.itemHpRegainIncrease;
		maxHp -= equippedItemStats.itemMaxHpIncrease;
		maxHp -= equippedItemStats.itemIncreaseBaseMaxHp;//double
		moveSpeed -= equippedItemStats.itemMoveSpeedIncrease;
		jumpHeight -= equippedItemStats.increaseJumpHeight;
		mercy -= equippedItemStats.increaseMercy;
		summonMaxHP -= equippedItemStats.increaseSummonMaxHP;
		summonMaxGP -= equippedItemStats.increaseSummonMaxGP;
		summonMindControl -= equippedItemStats.increaseSummonedMindControl;
		vengeance -= equippedItemStats.increaseVengeance;
		exodus -= equippedItemStats.increaseExodus;
		GPCostReduce -= equippedItemStats.itemGpCostReduce;
		GPDamage -= equippedItemStats.itemGpDamageIncrease;
		GPRegen -= equippedItemStats.increaseGPregeneration;
		GPRegen -= equippedItemStats.itemGpRegeneration;//double
		GPCritBonusDamage -= equippedItemStats.increaseGPCritBonusDamage;
		MaxGP -= equippedItemStats.maxGPincrease;
		GPResistance -= equippedItemStats.increaseGPresistance;
		MaxGP -= equippedItemStats.increaseMaxGP;//double
		GPCritDamage -= equippedItemStats.increaseGPcritDamage;
		defense -= equippedItemStats.itemDefense;
		defense -= equippedItemStats.itemDefenseIncrease; //double
		armorBonus -= equippedItemStats.increaseArmorBonus;
		resistWater -= equippedItemStats.itemWaterResist;
		bonusResistFire -= equippedItemStats.increaseBonusResistFire;
		bonusResistShadow -= equippedItemStats.increaseBonusResistShadow;
		resistLight -= equippedItemStats.resistLight;
		resistBlind -= equippedItemStats.resistBlind;
		resistMelted -= equippedItemStats.resistMelted;
		resistPoision -= equippedItemStats.resistPoision;
		resistSlow -= equippedItemStats.resistSlow;
		resistFright -= equippedItemStats.resistFright;
		resistHeadache -= equippedItemStats.resistHeadache;
		resistBrainFart -= equippedItemStats.resistBrainFart;
		resistArmCrushed -= equippedItemStats.resistArmCrushed;
		resistWeakened -= equippedItemStats.resistWeakened;
		resistBlasphemed -= equippedItemStats.resistBlasphemed;
		damageLoweredPerSecond -= equippedItemStats.itemDamagedLoweredPerSecond;
		damageIncreasedPerSecond -= equippedItemStats.itemDamagedIncresedPerSecond;
		armCrushTimer += equippedItemStats.decreaseArmCrushTimer;
		blasphemedTimer += equippedItemStats.decreaseBlasphemedTimer;
		stunTimer += equippedItemStats.lowerStunTimer;
		curseTimer += equippedItemStats.lowerCurseDebuffSeconds;
		muffledTimer += equippedItemStats.lowerMuffledDebuffSeconds;
		brainFartTimer += equippedItemStats.lowerBrainFartDebuffSeconds;
		jumpHeight += equippedItemStats.lowerJumpHeight;

	}
	// Update is called once per frame
	void Update () {
	
	}
}
