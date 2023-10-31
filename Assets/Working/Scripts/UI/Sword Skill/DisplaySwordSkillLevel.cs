using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySwordSkillLevel : MonoBehaviour
{
    [SerializeField] private Text _defaultFirstNormalSwordSkillLevelText;
    [SerializeField] private Text _defaultSecondNormalSwordSkilLevelText;

    [SerializeField] private Text _firstSwordSkill001LevelText;
    [SerializeField] private Text _firstSwordSkill002LevelText;
    [SerializeField] private Text _firstSwordSkill003LevelText;

    [SerializeField] private Text _secondSwordSkill001LevelText;
    [SerializeField] private Text _secondSwordSkill002LevelText;
    [SerializeField] private Text _secondSwordSkill003LevelText;

    [SerializeField] private Text _thirdSwordSkill001LevelText;
    [SerializeField] private Text _thirdSwordSkill002LevelText;
    [SerializeField] private Text _thirdSwordSkill003LevelText;


    // Update is called once per frame
    void Update()
    {
        // Normal Skill
        if (RuntimeSkillData.SkillDictionary["DefaultFirstNormalSwordSkill"].IsUnlocked)
        {
            _defaultFirstNormalSwordSkillLevelText.text = RuntimeSkillData.SkillDictionary["DefaultFirstNormalSwordSkill"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["DefaultSecondNormalSwordSkill"].IsUnlocked)
        {
            _defaultSecondNormalSwordSkilLevelText.text = RuntimeSkillData.SkillDictionary["DefaultSecondNormalSwordSkill"].Level.ToString();
        }

        // Skill 1
        if (RuntimeSkillData.SkillDictionary["FirstSwordSkill001"].IsUnlocked)
        {
            _firstSwordSkill001LevelText.text = RuntimeSkillData.SkillDictionary["FirstSwordSkill001"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["FirstSwordSkill002"].IsUnlocked)
        {
            _firstSwordSkill002LevelText.text = RuntimeSkillData.SkillDictionary["FirstSwordSkill002"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["FirstSwordSkill003"].IsUnlocked)
        {
            _firstSwordSkill003LevelText.text = RuntimeSkillData.SkillDictionary["FirstSwordSkill003"].Level.ToString();
        }

        // Skill 2

        if (RuntimeSkillData.SkillDictionary["SecondSwordSkill001"].IsUnlocked)
        {
            _secondSwordSkill001LevelText.text = RuntimeSkillData.SkillDictionary["SecondSwordSkill001"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["SecondSwordSkill002"].IsUnlocked)
        {
            _secondSwordSkill002LevelText.text = RuntimeSkillData.SkillDictionary["SecondSwordSkill002"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["SecondSwordSkill003"].IsUnlocked)
        {
            _secondSwordSkill003LevelText.text = RuntimeSkillData.SkillDictionary["SecondSwordSkill003"].Level.ToString();
        }

        // Skill 3

        if (RuntimeSkillData.SkillDictionary["ThirdSwordSkill001"].IsUnlocked)
        {
            _thirdSwordSkill001LevelText.text = RuntimeSkillData.SkillDictionary["ThirdSwordSkill001"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["ThirdSwordSkill002"].IsUnlocked)
        {
            _thirdSwordSkill002LevelText.text = RuntimeSkillData.SkillDictionary["ThirdSwordSkill002"].Level.ToString();
        }
        if (RuntimeSkillData.SkillDictionary["ThirdSwordSkill003"].IsUnlocked)
        {
            _thirdSwordSkill003LevelText.text = RuntimeSkillData.SkillDictionary["ThirdSwordSkill003"].Level.ToString();
        }
    }
}
