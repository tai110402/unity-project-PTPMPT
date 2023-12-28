using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeEquipmentData : MonoBehaviour
{
    private static bool _initializeData = false;
    private static EquipmentData _equipmentData;
    public static EquipmentData EquipmentData { set { _equipmentData = value; } get { return _equipmentData; } }
    public static bool InitializeData { set { _initializeData = value; } }

    // Start is called before the first frame update
    void Start()
    {
        if (_initializeData == false)
        {
            InitializeEquipmentDefaultValue();
            _initializeData = true;
        }
    }

    public static void InitializeEquipmentDefaultValue()
    {
        _equipmentData = new EquipmentData()
        {
            ArmorData = new ArmorData() { Armor = new int[] { 100, 200, 400, 500 }, Level = 1, MaxLevel = 4, GoldToUpgradeLevel = new int[] { 30, 40, 50, 60 } },
            WeaponDataArray = new WeaponData[]
            {
                new WeaponData { WeaponName = "Shield" ,Damage = new int[] {100, 120, 150, 200}, Level = 1, MaxLevel = 4, GoldToUpgradeLevel = new int[] { 30, 40, 50, 60 } },
                new WeaponData { WeaponName = "Sword" ,Damage = new int[] {100, 120, 150, 200}, Level = 1, MaxLevel = 4, GoldToUpgradeLevel = new int[] { 30, 40, 50, 60 } },
                //new WeaponData { WeaponName = "Axe" ,Damage = new int[] {300, 400, 500, 600}, Level = 1, MaxLevel = 4, GoldToUpgradeLevel = new int[] { 30, 40, 50, 60 } }
                new WeaponData { WeaponName = "Axe" ,Damage = new int[] {500, 500, 1000, 2000}, Level = 1, MaxLevel = 4, GoldToUpgradeLevel = new int[] { 30, 40, 50, 60 } } // data test
            }
        };
    }

    public static EquipmentData GetEquipmentData()
    {
        return _equipmentData;
    }
}
