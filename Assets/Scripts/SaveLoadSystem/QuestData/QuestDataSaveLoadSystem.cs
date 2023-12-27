using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class QuestDataSaveLoadSystem : MonoBehaviour
{
    public static void SaveQuestData()
    {
        QuestData questData = RuntimeQuestData.GetQuestData();
        string json = JsonUtility.ToJson(questData, true);
        File.WriteAllText(Application.dataPath + "/QuestData.json", json);
        Debug.Log("DataSave: " + json);
    }

    public static void LoadQuestData()
    {
        string json = File.ReadAllText(Application.dataPath + "/QuestData.json");
        QuestData questData = JsonUtility.FromJson<QuestData>(json);
        Debug.Log("DataLoad: " + json);
        RuntimeQuestData.LoadQuestData(questData);
    }
}
