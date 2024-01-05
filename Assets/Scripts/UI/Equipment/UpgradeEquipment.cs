using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeEquipment : MonoBehaviour
{
    public void UpgradeShield()
    {
        WeaponData shield = RuntimeEquipmentData.EquipmentData.WeaponDataArray[0];
        if (shield.Level < shield.MaxLevel && RuntimePlayerData.PlayerData.Gold >= shield.GoldToUpgradeLevel[shield.Level - 1])
        {
            RuntimePlayerData.PlayerData.Gold -= shield.GoldToUpgradeLevel[shield.Level - 1];
            shield.Level += 1;
        }
    }

    public void UpgradeSword()
    {
        WeaponData sword = RuntimeEquipmentData.EquipmentData.WeaponDataArray[1];
        if (sword.Level < sword.MaxLevel && RuntimePlayerData.PlayerData.Gold >= sword.GoldToUpgradeLevel[sword.Level - 1])
        {
            RuntimePlayerData.PlayerData.Gold -= sword.GoldToUpgradeLevel[sword.Level - 1];
            sword.Level += 1;
        }
    }

    public void UpgradeAxe()
    {
        WeaponData axe = RuntimeEquipmentData.EquipmentData.WeaponDataArray[2];
        if (axe.Level < axe.MaxLevel && RuntimePlayerData.PlayerData.Gold >= axe.GoldToUpgradeLevel[axe.Level - 1])
        {
            RuntimePlayerData.PlayerData.Gold -= axe.GoldToUpgradeLevel[axe.Level - 1];
            axe.Level += 1;
        }
    }

    public void UpgradeArmor()
    {
        ArmorData armor = RuntimeEquipmentData.EquipmentData.ArmorData;
        if (armor.Level < armor.MaxLevel && RuntimePlayerData.PlayerData.Gold >= armor.GoldToUpgradeLevel[armor.Level - 1])
        {
            RuntimePlayerData.PlayerData.Gold -= armor.GoldToUpgradeLevel[armor.Level - 1];
            armor.Level += 1;
        }
    }
}
