using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaplayAxeSkillLevel : MonoBehaviour
{
    [SerializeField] private Text _defaultFirstNormalAxeSkillLevelText;
    [SerializeField] private Text _defaultSecondNormalAxeSkilLevelText;

    [SerializeField] private Text _firstAxeSkill001LevelText;

    [SerializeField] private Text _secondAxeSkill001LevelText;
    [SerializeField] private Text _secondAxeSkill002LevelText;
    [SerializeField] private Text _secondAxeSkill003LevelText;

    [SerializeField] private Text _thirdAxeSkill001LevelText;
    [SerializeField] private Text _thirdAxeSkill002LevelText;
    [SerializeField] private Text _thirdAxeSkill003LevelText;

    // Update is called once per frame
    void Update()
    {
        // Normal Skill
        if (RuntimeSkillData.SkillDictionary["DefaultFirstNormalAxeSkill"].IsUnlocked)
        {
            _defaultFirstNormalAxeSkillLevelText.text = RuntimeSkillData.SkillDictionary["DefaultFirstNormalAxeSkill"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["DefaultSecondNormalAxeSkill"].IsUnlocked)
        {
            _defaultSecondNormalAxeSkilLevelText.text = RuntimeSkillData.SkillDictionary["DefaultSecondNormalAxeSkill"].Level.ToString();
        }

        // Skill 1
        if (RuntimeSkillData.SkillDictionary["FirstAxeSkill001"].IsUnlocked)
        {
            _firstAxeSkill001LevelText.text = RuntimeSkillData.SkillDictionary["FirstAxeSkill001"].Level.ToString();
        }

        // Skill 2

        if (RuntimeSkillData.SkillDictionary["SecondAxeSkill001"].IsUnlocked)
        {
            _secondAxeSkill001LevelText.text = RuntimeSkillData.SkillDictionary["SecondAxeSkill001"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["SecondAxeSkill002"].IsUnlocked)
        {
            _secondAxeSkill002LevelText.text = RuntimeSkillData.SkillDictionary["SecondAxeSkill002"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["SecondAxeSkill003"].IsUnlocked)
        {
            _secondAxeSkill003LevelText.text = RuntimeSkillData.SkillDictionary["SecondAxeSkill003"].Level.ToString();
        }

        // Skill 3

        if (RuntimeSkillData.SkillDictionary["ThirdAxeSkill001"].IsUnlocked)
        {
            _thirdAxeSkill001LevelText.text = RuntimeSkillData.SkillDictionary["ThirdAxeSkill001"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["ThirdAxeSkill002"].IsUnlocked)
        {
            _thirdAxeSkill002LevelText.text = RuntimeSkillData.SkillDictionary["ThirdAxeSkill002"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["ThirdAxeSkill003"].IsUnlocked)
        {
            _thirdAxeSkill003LevelText.text = RuntimeSkillData.SkillDictionary["ThirdAxeSkill003"].Level.ToString();
        }
    }
}
