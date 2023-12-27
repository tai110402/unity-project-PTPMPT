using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class RuntimeSkillData: MonoBehaviour
{
    private static Dictionary<string, Skill> _skillDictionary = new Dictionary<string, Skill>();
    public static Dictionary<string, Skill> SkillDictionary {get { return _skillDictionary; } }

    private void Awake()
    {
        InitializeSkillDataDefaultValue();
    }
    public static void InitializeSkillDataDefaultValue()
    {
        _skillDictionary.Add("DefaultBlockSkill001", new Skill() { AnimationName = "DefaultBlockSkill001", TimeCoolDown = new float[] { 1f, 1f, 1f, 1f, 1f}, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 40, 50, 60, 90, 100 } });
        _skillDictionary.Add("DefaultBlockSkill002", new Skill() { AnimationName = "DefaultBlockSkill002", TimeCoolDown = new float[] { 1f, 1f, 1f, 1f, 1f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 40, 50, 60, 90, 100 } });

        _skillDictionary.Add("DefaultFirstNormalSwordSkill", new Skill() { AnimationName = "DefaultFirstNormalSwordSkill", TimeCoolDown = new float[] { 0f, 0f, 0f, 0f, 0f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("DefaultSecondNormalSwordSkill", new Skill() { AnimationName = "DefaultSecondNormalSwordSkill", TimeCoolDown = new float[] { 0f, 0f, 0f, 0f, 0f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });

        _skillDictionary.Add("FirstSwordSkill001", new Skill() { AnimationName = "FirstSwordSkill001", TimeCoolDown = new float[] { 10f, 9f, 9f, 8f, 8f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("FirstSwordSkill002", new Skill() { AnimationName = "FirstSwordSkill002", TimeCoolDown = new float[] { 10f, 9f, 9f, 8f, 8f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("FirstSwordSkill003", new Skill() { AnimationName = "FirstSwordSkill003", TimeCoolDown = new float[] { 10f, 9f, 9f, 8f, 8f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        
        _skillDictionary.Add("SecondSwordSkill001", new Skill() { AnimationName = "SecondSwordSkill001", TimeCoolDown = new float[] { 15f, 15f, 14f, 14f, 13f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1, 1.1f, 1.2f } }, new SkillSlash() { Slash = new float[] { 1.1f, 1.2f, 1.3f } }, new SkillSlash() { Slash = new float[] { 1.2f, 1.3f, 1.4f } }, new SkillSlash() { Slash = new float[] { 1.3f, 1.4f, 1.5f } }, new SkillSlash() { Slash = new float[] { 1.4f, 1.5f, 1.6f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5 , ExpToUpgradeArray = new int[] { 20, 30, 40, 50, 60 } });
        _skillDictionary.Add("SecondSwordSkill002", new Skill() { AnimationName = "SecondSwordSkill002", TimeCoolDown = new float[] { 15f, 15f, 14f, 14f, 13f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1, 1.1f, 1.2f } }, new SkillSlash() { Slash = new float[] { 1.1f, 1.2f, 1.3f } }, new SkillSlash() { Slash = new float[] { 1.2f, 1.3f, 1.4f } }, new SkillSlash() { Slash = new float[] { 1.3f, 1.4f, 1.5f } }, new SkillSlash() { Slash = new float[] { 1.4f, 1.5f, 1.6f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5 , ExpToUpgradeArray = new int[] { 20, 30, 40, 50, 60 } });
        _skillDictionary.Add("SecondSwordSkill003", new Skill() { AnimationName = "SecondSwordSkill003", TimeCoolDown = new float[] { 15f, 15f, 14f, 14f, 13f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1, 1.1f, 1.2f } }, new SkillSlash() { Slash = new float[] { 1.1f, 1.2f, 1.3f } }, new SkillSlash() { Slash = new float[] { 1.2f, 1.3f, 1.4f } }, new SkillSlash() { Slash = new float[] { 1.3f, 1.4f, 1.5f } }, new SkillSlash() { Slash = new float[] { 1.4f, 1.5f, 1.6f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5 , ExpToUpgradeArray = new int[] { 20, 30, 40, 50, 60 } });

        _skillDictionary.Add("ThirdSwordSkill001", new Skill() { AnimationName = "ThirdSwordSkill001", TimeCoolDown = new float[] { 10f, 9f, 9f, 8f, 8f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("ThirdSwordSkill002", new Skill() { AnimationName = "ThirdSwordSkill002", TimeCoolDown = new float[] { 10f, 9f, 9f, 8f, 8f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("ThirdSwordSkill003", new Skill() { AnimationName = "ThirdSwordSkill003", TimeCoolDown = new float[] { 10f, 9f, 9f, 8f, 8f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });


        _skillDictionary.Add("DefaultFirstNormalAxeSkill", new Skill() { AnimationName = "DefaultFirstNormalAxeSkill", TimeCoolDown = new float[] { 0f, 0f, 0f, 0f, 0f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("DefaultSecondNormalAxeSkill", new Skill() { AnimationName = "DefaultSecondNormalAxeSkill", TimeCoolDown = new float[] { 0f, 0f, 0f, 0f, 0f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });

        _skillDictionary.Add("FirstAxeSkill001", new Skill() { AnimationName = "FirstAxeSkill001", TimeCoolDown = new float[] { 5f, 4f, 3f, 2f, 2f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        
        _skillDictionary.Add("SecondAxeSkill001", new Skill() { AnimationName = "SecondAxeSkill001", TimeCoolDown = new float[] { 25f, 23f, 21f, 19f, 16f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1, 1.1f, 1.2f } }, new SkillSlash() { Slash = new float[] { 1.1f, 1.2f, 1.3f } }, new SkillSlash() { Slash = new float[] { 1.2f, 1.3f, 1.4f } }, new SkillSlash() { Slash = new float[] { 1.3f, 1.4f, 1.5f } }, new SkillSlash() { Slash = new float[] { 1.4f, 1.5f, 1.6f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 20, 30, 40, 50, 60 } });
        _skillDictionary.Add("SecondAxeSkill002", new Skill() { AnimationName = "SecondAxeSkill002", TimeCoolDown = new float[] { 25f, 23f, 21f, 19f, 16f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1, 1.1f, 1.2f } }, new SkillSlash() { Slash = new float[] { 1.1f, 1.2f, 1.3f } }, new SkillSlash() { Slash = new float[] { 1.2f, 1.3f, 1.4f } }, new SkillSlash() { Slash = new float[] { 1.3f, 1.4f, 1.5f } }, new SkillSlash() { Slash = new float[] { 1.4f, 1.5f, 1.6f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 20, 30, 40, 50, 60 } });
        _skillDictionary.Add("SecondAxeSkill003", new Skill() { AnimationName = "SecondAxeSkill003", TimeCoolDown = new float[] { 25f, 23f, 21f, 19f, 16f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1, 1.1f, 1.2f } }, new SkillSlash() { Slash = new float[] { 1.1f, 1.2f, 1.3f } }, new SkillSlash() { Slash = new float[] { 1.2f, 1.3f, 1.4f } }, new SkillSlash() { Slash = new float[] { 1.3f, 1.4f, 1.5f } }, new SkillSlash() { Slash = new float[] { 1.4f, 1.5f, 1.6f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 20, 30, 40, 50, 60 } });

        _skillDictionary.Add("ThirdAxeSkill001", new Skill() { AnimationName = "ThirdAxeSkill001", TimeCoolDown = new float[] { 20f, 18f, 17f, 16f, 14f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("ThirdAxeSkill002", new Skill() { AnimationName = "ThirdAxeSkill002", TimeCoolDown = new float[] { 20f, 18f, 17f, 16f, 14f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });
        _skillDictionary.Add("ThirdAxeSkill003", new Skill() { AnimationName = "ThirdAxeSkill003", TimeCoolDown = new float[] { 20f, 18f, 17f, 16f, 14f }, SlashArray = new SkillSlash[] { new SkillSlash() { Slash = new float[] { 1f } }, new SkillSlash() { Slash = new float[] { 1.2f } }, new SkillSlash() { Slash = new float[] { 1.5f } }, new SkillSlash() { Slash = new float[] { 1.8f } }, new SkillSlash() { Slash = new float[] { 2.3f } } }, IsUnlocked = false, IsUsing = false, Level = 1, MaxLevel = 5, ExpToUpgradeArray = new int[] { 10, 20, 30, 40, 50 } });

    }

    public static Skill[] GetUnlockSkill()
    {
        Skill[] unlockedSkillArray = new Skill[0];
        foreach (var keyValuePair in _skillDictionary)
        {
            if (keyValuePair.Value.IsUnlocked == true)
            {
                Array.Resize(ref unlockedSkillArray, unlockedSkillArray.Length + 1);
                unlockedSkillArray[unlockedSkillArray.Length - 1] = keyValuePair.Value;
            }
        }
        return unlockedSkillArray;
    }

    public static Skill[] GetUsingSkill()
    {
        Skill[] usingSkillArray = new Skill[0];
        foreach (var keyValuePair in _skillDictionary)
        {
            if (keyValuePair.Value.IsUsing == true)
            {
                Array.Resize(ref usingSkillArray, usingSkillArray.Length + 1);
                usingSkillArray[usingSkillArray.Length - 1] = keyValuePair.Value;
            }
        }
        return usingSkillArray;
    }

    public static Skill[] GetSkillArray()
    {
        Skill[] skillArray = new Skill[0];
        foreach (var keyValuePair in _skillDictionary)
        {
             Array.Resize(ref skillArray, skillArray.Length + 1);
             skillArray[skillArray.Length - 1] = keyValuePair.Value;
        }
        return skillArray;
    }

    public static SkillData GetSkillData()
    {
        SkillData skillData = new SkillData();
        foreach (var keyValuePair in _skillDictionary)
        {
            skillData.AddSkill(keyValuePair.Value);
        }
        return skillData;
    }

    public static void LoadSkillData(SkillData skillData)
    {
        var keyArray = new List<string>(_skillDictionary.Keys);
        for (int i = 0; i < keyArray.Count; i++)
        {
            _skillDictionary[keyArray[i]] = skillData.Skills[i];
            Debug.Log("ok");
        }
    }
}
