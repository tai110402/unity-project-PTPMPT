using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SkillDataSaveLoadSystem
{
    public static void SaveSkillData()
    {
        SkillData skillData = RuntimeSkillData.GetSkillData();
        string json = JsonUtility.ToJson(skillData, true);
        File.WriteAllText(Application.dataPath + "/SkillData.json", json);
        Debug.Log("DataSave: " + json);
    }

    public static void LoadSkillData()
    {
        string json = File.ReadAllText(Application.dataPath + "/SkillData.json");
        SkillData skillData = JsonUtility.FromJson<SkillData>(json);
        Debug.Log("DataLoad: " + json);
        RuntimeSkillData.LoadSkillData(skillData);
    }
}
