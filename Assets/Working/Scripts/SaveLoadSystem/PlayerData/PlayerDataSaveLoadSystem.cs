using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerDataSaveLoadSystem
{
    public static void SavePlayerData()
    {
        PlayerData playerData = RuntimePlayerData.GetPlayerData();
        string json = JsonUtility.ToJson(playerData, true);
        File.WriteAllText(Application.dataPath + "/PlayerData.json", json);
        Debug.Log("DataSave: " + json);
    }

    public static void LoadPlayerData()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerData.json");
        PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log("DataLoad: " + json);
        RuntimePlayerData.LoadPlayerData(playerData);
    }
}
