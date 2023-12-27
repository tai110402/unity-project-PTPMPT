using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayShieldUpgradeRequirement : MonoBehaviour
{
    [SerializeField] private Text _defaultBlockSkill001RequireText;
    [SerializeField] private Text _defaultBlockSkill002RequireText;

    // Update is called once per frame
    void Update()
    {
        Display("DefaultBlockSkill001", _defaultBlockSkill001RequireText);
        Display("DefaultBlockSkill002", _defaultBlockSkill002RequireText);
    }

    private void Display(string skillName, Text skillUpgradeRequirementText)
    {
        Skill skill = RuntimeSkillData.SkillDictionary[skillName];
        if (skill.IsUnlocked)
        {
            if (skill.Level < skill.MaxLevel - 1)
            {
                skillUpgradeRequirementText.text = "< Exp: " + skill.ExpToUpgradeArray[skill.Level - 1] + " >";
            }
            else if (skill.Level == skill.MaxLevel - 1)
            {
                skillUpgradeRequirementText.text = "< Exp: " + skill.ExpToUpgradeArray[skill.Level - 1] + ", BKP: 1 >";
            }
            else if (skill.Level == skill.MaxLevel)
            {
                skillUpgradeRequirementText.text = "< Max Level >";
            }
        }
    }
}
