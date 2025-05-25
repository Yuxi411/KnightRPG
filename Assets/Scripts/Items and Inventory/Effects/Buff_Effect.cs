using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatType
{
    strength,
    agility,
    intelligence,
    vitality,
    damage,
    critChance,
    critPower,
    health,
    armor,
    evasion,
    magicRes,
    fireDamage,
    iceDamage,
    lightingDamage,
}

[CreateAssetMenu(fileName = "Buff effect", menuName = "Data/Item effect/Buff effect")]

public class Buff_Effect : ItemEffect
{
    private PlayerStats stats;
    [SerializeField] private StatType buffedType;
    [SerializeField] private int buffAmount;
    [SerializeField] private float buffDuration;

    public override void ExecuteEffect(Transform _enemyPosition)
    {
        stats = PlayerManager.instance.player.GetComponent<PlayerStats>();
        stats.IncreaseStatBy(buffAmount, buffDuration, StatToModify());
    }

    private Stat StatToModify()
    {
        if (buffedType == StatType.strength)
            return stats.strength;
        else if (buffedType == StatType.agility)
            return stats.agility;
        else if (buffedType == StatType.intelligence)
            return stats.intelligence;
        else if (buffedType == StatType.vitality)
            return stats.vitality;
        else if (buffedType == StatType.damage)
            return stats.damage;
        else if (buffedType == StatType.critChance)
            return stats.critChance;
        else if (buffedType == StatType.critPower)
            return stats.critPower;
        else if (buffedType == StatType.health)
            return stats.maxHealth;
        else if (buffedType == StatType.armor)
            return stats.armor;
        else if (buffedType == StatType.evasion)
            return stats.evasion;
        else if (buffedType == StatType.magicRes)
            return stats.magicResistance;
        else if (buffedType == StatType.fireDamage)
            return stats.fireDamage;
        else if (buffedType == StatType.iceDamage)
            return stats.iceDamage;
        else if (buffedType == StatType.lightingDamage)
            return stats.lightingDamage;

        return null;
    }
}
