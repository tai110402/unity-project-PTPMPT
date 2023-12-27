using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEquipmentLevel : MonoBehaviour
{
    [SerializeField] private Text _shieldLevelText;
    [SerializeField] private Text _swordLevelText;
    [SerializeField] private Text _axeLevelText;
    [SerializeField] private Text _armorLevelText;

    // Update is called once per frame
    void Update()
    {
        _shieldLevelText.text = "Level: " + RuntimeEquipmentData.EquipmentData.WeaponDataArray[0].Level.ToString();
        _swordLevelText.text = "Level: " + RuntimeEquipmentData.EquipmentData.WeaponDataArray[1].Level.ToString();
        _axeLevelText.text = "Level: " + RuntimeEquipmentData.EquipmentData.WeaponDataArray[2].Level.ToString();
        _armorLevelText.text = "Level: " + RuntimeEquipmentData.EquipmentData.ArmorData.Level.ToString();
    }
}
