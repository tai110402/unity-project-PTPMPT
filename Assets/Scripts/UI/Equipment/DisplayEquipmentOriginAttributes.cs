using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEquipmentOriginAttributes : MonoBehaviour
{
    [SerializeField] private Text _shieldOriginDamageText;
    [SerializeField] private Text _swordOriginDamageText;
    [SerializeField] private Text _axeOriginDamageText;
    [SerializeField] private Text _armorOriginDamageText;

    // Update is called once per frame
    void Update()
    {
        WeaponData shield = RuntimeEquipmentData.EquipmentData.WeaponDataArray[0];
        WeaponData sword = RuntimeEquipmentData.EquipmentData.WeaponDataArray[1];
        WeaponData axe = RuntimeEquipmentData.EquipmentData.WeaponDataArray[2];
        ArmorData armor = RuntimeEquipmentData.EquipmentData.ArmorData;

        _shieldOriginDamageText.text = "Damage: " + shield.Damage[shield.Level - 1].ToString();
        _swordOriginDamageText.text = "Damage: " + sword.Damage[sword.Level - 1].ToString();
        _axeOriginDamageText.text = "Damage: " + axe.Damage[axe.Level - 1].ToString();
        _armorOriginDamageText.text = "Armor: " + armor.Armor[armor.Level - 1].ToString();
    }
}
