using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySwordUpgradeRequirement : MonoBehaviour
{
    [SerializeField] private Text _defaultFirstNormalSwordSkillRequireText;
    [SerializeField] private Text _defaultSecondNormalSwordSkillRequireText;

    [SerializeField] private Text _firstSwordSkill001UpgradeRequireText;
    [SerializeField] private Text _firstSwordSkill002UpgradeRequireText;
    [SerializeField] private Text _firstSwordSkill003UpgradeRequireText;

    [SerializeField] private Text _secondSwordSkill001UpgradeRequireText;
    [SerializeField] private Text _secondSwordSkill002UpgradeRequireText;
    [SerializeField] private Text _secondSwordSkill003UpgradeRequireText;

    [SerializeField] private Text _thirdSwordSkill001UpgradeRequireText;
    [SerializeField] private Text _thirdSwordSkill002UpgradeRequireText;
    [SerializeField] private Text _thirdSwordSkill003UpgradeRequireText;

    // Update is called once per frame
    void Update()
    {
        Display("DefaultFirstNormalSwordSkill", _defaultFirstNormalSwordSkillRequireText);
        Display("DefaultSecondNormalSwordSkill", _defaultSecondNormalSwordSkillRequireText);

        Display("FirstSwordSkill001", _firstSwordSkill001UpgradeRequireText);
        Display("FirstSwordSkill002", _firstSwordSkill002UpgradeRequireText);
        Display("FirstSwordSkill003", _firstSwordSkill003UpgradeRequireText);

        Display("SecondSwordSkill001", _secondSwordSkill001UpgradeRequireText);
        Display("SecondSwordSkill002", _secondSwordSkill002UpgradeRequireText);
        Display("SecondSwordSkill003", _secondSwordSkill003UpgradeRequireText);

        Display("ThirdSwordSkill001", _thirdSwordSkill001UpgradeRequireText);
        Display("ThirdSwordSkill002", _thirdSwordSkill002UpgradeRequireText);
        Display("ThirdSwordSkill003", _thirdSwordSkill003UpgradeRequireText);

    }

    private void Display(string skillName, Text skillUpgradeRequirementText)
    {
        Skill skill = RuntimeSkillData.SkillDictionary[skillName];
        if (skill.IsUnlocked)
        {
            if (skill.Level < skill.MaxLevel-1)
            {
                skillUpgradeRequirementText.text = "< Exp: " + skill.ExpToUpgradeArray[skill.Level - 1] + " >";
            } else if (skill.Level == skill.MaxLevel - 1)
            {
                skillUpgradeRequirementText.text = "< Exp: " + skill.ExpToUpgradeArray[skill.Level - 1] + ", BKP: 1 >"; 
            } else if (skill.Level == skill.MaxLevel)
            {
                skillUpgradeRequirementText.text = "< Max Level >";
            }
        }
    }
}
