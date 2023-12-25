using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EquipmentDataSaveLoadSystem : MonoBehaviour
{
    public static void SaveEquipmentData()
    {
        EquipmentData equipmentData = RuntimeEquipmentData.EquipmentData;
        string json = JsonUtility.ToJson(equipmentData, true);
        File.WriteAllText(Application.dataPath + "/EquipmentData.json", json);
        Debug.Log("DataSave " + json);
    }

    public static void LoadEquipmentData()
    {
        string json = File.ReadAllText(Application.dataPath + "/EquipmentData.json");
        EquipmentData equipmentData = JsonUtility.FromJson<EquipmentData>(json);
        Debug.Log("DataLoad: " + json);
        RuntimeEquipmentData.EquipmentData = equipmentData;
    }
}
