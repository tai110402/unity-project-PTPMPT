using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayShieldSkillLevel : MonoBehaviour
{
    [SerializeField] private Text _defaultBlockSkill001LevelText;
    [SerializeField] private Text _defaultBlockSkill002LevelText;

    // Update is called once per frame
    void Update()
    {
        // Normal Skill
        if (RuntimeSkillData.SkillDictionary["DefaultBlockSkill001"].IsUnlocked)
        {
            _defaultBlockSkill001LevelText.text = RuntimeSkillData.SkillDictionary["DefaultBlockSkill001"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["DefaultBlockSkill002"].IsUnlocked)
        {
            _defaultBlockSkill002LevelText.text = RuntimeSkillData.SkillDictionary["DefaultBlockSkill002"].Level.ToString();
        }
    }
}
