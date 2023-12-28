using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosingAxeSkill : MonoBehaviour
{
    [SerializeField] private Image _firstNormalAxeSkillBackGround;
    [SerializeField] private Image _secondNormalAxeSkillBackGround;

    [SerializeField] private Image _firstAxeSkill001BackGround;

    [SerializeField] private Image _secondAxeSkill001BackGround;
    [SerializeField] private Image _secondAxeSkill002BackGround;
    [SerializeField] private Image _secondAxeSkill003BackGround;

    [SerializeField] private Image _thirdAxeSkill001BackGround;
    [SerializeField] private Image _thirdAxeSkill002BackGround;
    [SerializeField] private Image _thirdAxeSkill003BackGround;

    private void Update()
    {
        // Normal Skill
        UpdateButtonColor("DefaultFirstNormalAxeSkill", _firstNormalAxeSkillBackGround);
        UpdateButtonColor("DefaultSecondNormalAxeSkill", _secondNormalAxeSkillBackGround);

        // Skill 1
        UpdateButtonColor("FirstAxeSkill001", _firstAxeSkill001BackGround);

        // Skill 2
        UpdateButtonColor("SecondAxeSkill001", _secondAxeSkill001BackGround);
        UpdateButtonColor("SecondAxeSkill002", _secondAxeSkill002BackGround);
        UpdateButtonColor("SecondAxeSkill003", _secondAxeSkill003BackGround);

        // Skill 3
        UpdateButtonColor("ThirdAxeSkill001", _thirdAxeSkill001BackGround);
        UpdateButtonColor("ThirdAxeSkill002", _thirdAxeSkill002BackGround);
        UpdateButtonColor("ThirdAxeSkill003", _thirdAxeSkill003BackGround);

    }

    private void UpdateButtonColor(string skillName, Image backGroundImage)
    {
        if (RuntimeSkillData.SkillDictionary[skillName].IsUnlocked == true)
        {
            if (RuntimeSkillData.SkillDictionary[skillName].IsUsing == false)
            {
                backGroundImage.color = Color.white;
            }
            else
            {
                backGroundImage.color = new Color32(182, 242, 255, 255);
            }
        }
    }

    // Skill 1
    public void UsingFirstAxeSkill001()
    {
        if (RuntimeSkillData.SkillDictionary["FirstAxeSkill001"].IsUnlocked == true)
        {
            RuntimeSkillData.SkillDictionary["FirstAxeSkill001"].IsUsing = true;
        }
    }

    // Skill 2
    public void UsingSecondAxeSkill001()
    {
        UsingSkill("SecondAxeSkill001", "SecondAxeSkill002", "SecondAxeSkill003");
    }

    public void UsingSecondAxeSkill002()
    {
        UsingSkill("SecondAxeSkill002", "SecondAxeSkill001", "SecondAxeSkill003");
    }

    public void UsingSecondAxeSkill003()
    {
        UsingSkill("SecondAxeSkill003", "SecondAxeSkill001", "SecondAxeSkill002");
    }

    // Skill 3
    public void UsingThirdAxeSkill001()
    {
        UsingSkill("ThirdAxeSkill001", "ThirdAxeSkill002", "ThirdAxeSkill003");
    }

    public void UsingThirdAxeSkill002()
    {
        UsingSkill("ThirdAxeSkill002", "ThirdAxeSkill001", "ThirdAxeSkill003");
    }

    public void UsingThirdAxeSkill003()
    {
        UsingSkill("ThirdAxeSkill003", "ThirdAxeSkill001", "ThirdAxeSkill002");
    }

    private void UsingSkill(string usingSkillName, string unUsingSkillName1, string unUsingSkillName2)
    {
        if (RuntimeSkillData.SkillDictionary[usingSkillName].IsUnlocked == true)
        {
            RuntimeSkillData.SkillDictionary[usingSkillName].IsUsing = true;
            RuntimeSkillData.SkillDictionary[unUsingSkillName1].IsUsing = false;
            RuntimeSkillData.SkillDictionary[unUsingSkillName2].IsUsing = false;
        }
    }
}
