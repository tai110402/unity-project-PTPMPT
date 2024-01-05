using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEquipmentUpgradeRequirement : MonoBehaviour
{
    [SerializeField] private Text _shieldUpgradeRequirementText;
    [SerializeField] private Text _swordUpgradeRequirementText;
    [SerializeField] private Text _axeUpgradeRequirementText;
    [SerializeField] private Text _armorUpgradeRequirementText;

    // Update is called once per frame
    void Update()
    {
        WeaponData shield = RuntimeEquipmentData.EquipmentData.WeaponDataArray[0];
        WeaponData sword = RuntimeEquipmentData.EquipmentData.WeaponDataArray[1];
        WeaponData axe = RuntimeEquipmentData.EquipmentData.WeaponDataArray[2];
        ArmorData armor = RuntimeEquipmentData.EquipmentData.ArmorData;

        DisplayRequire(shield, _shieldUpgradeRequirementText);
        DisplayRequire(sword, _swordUpgradeRequirementText);
        DisplayRequire(axe, _axeUpgradeRequirementText);

        if (armor.Level != armor.MaxLevel)
        {
            _armorUpgradeRequirementText.text = "< Gold: " + armor.GoldToUpgradeLevel[armor.Level - 1] + " >";
        }
        else
        {
            _armorUpgradeRequirementText.text = "< Max Level >";
        }

    }

    private void DisplayRequire(WeaponData weapon, Text requireText)
    {
        if (weapon.Level != weapon.MaxLevel)
        {
            requireText.text = "< Gold: " + weapon.GoldToUpgradeLevel[weapon.Level - 1] + " >";
        }
        else
        {
            requireText.text = "< Max Level >";
        }
    }
}
