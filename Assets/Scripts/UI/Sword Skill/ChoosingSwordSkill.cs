using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosingSwordSkill : MonoBehaviour
{
    [SerializeField] private Image _firstNormalSwordSkillBackGround;
    [SerializeField] private Image _secondNormalSwordSkillBackGround;

    [SerializeField] private Image _firstSwordSkill001BackGround;
    [SerializeField] private Image _firstSwordSkill002BackGround;
    [SerializeField] private Image _firstSwordSkill003BackGround;

    [SerializeField] private Image _secondSwordSkill001BackGround;
    [SerializeField] private Image _secondSwordSkill002BackGround;
    [SerializeField] private Image _secondSwordSkill003BackGround;

    [SerializeField] private Image _thirdSwordSkill001BackGround;
    [SerializeField] private Image _thirdSwordSkill002BackGround;
    [SerializeField] private Image _thirdSwordSkill003BackGround;

    private void Update()
    {
        // Normal Skill
        UpdateButtonColor("DefaultFirstNormalSwordSkill", _firstNormalSwordSkillBackGround);
        UpdateButtonColor("DefaultSecondNormalSwordSkill", _secondNormalSwordSkillBackGround);

        // Skill 1
        UpdateButtonColor("FirstSwordSkill001", _firstSwordSkill001BackGround);
        UpdateButtonColor("FirstSwordSkill002", _firstSwordSkill002BackGround);
        UpdateButtonColor("FirstSwordSkill003", _firstSwordSkill003BackGround);

        // Skill 2
        UpdateButtonColor("SecondSwordSkill001", _secondSwordSkill001BackGround);
        UpdateButtonColor("SecondSwordSkill002", _secondSwordSkill002BackGround);
        UpdateButtonColor("SecondSwordSkill003", _secondSwordSkill003BackGround);

        // Skill 3
        UpdateButtonColor("ThirdSwordSkill001", _thirdSwordSkill001BackGround);
        UpdateButtonColor("ThirdSwordSkill002", _thirdSwordSkill002BackGround);
        UpdateButtonColor("ThirdSwordSkill003", _thirdSwordSkill003BackGround);
        
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
    public void UsingFirstSwordSkill001()
    {
        UsingSkill("FirstSwordSkill001", "FirstSwordSkill002", "FirstSwordSkill003");
    }

    public void UsingFirstSwordSkill002()
    {
        UsingSkill("FirstSwordSkill002", "FirstSwordSkill001", "FirstSwordSkill003");
    }

    public void UsingFirstSwordSkill003()
    {
        UsingSkill("FirstSwordSkill003", "FirstSwordSkill001", "FirstSwordSkill002");
    }

    // Skill 2
    public void UsingSecondSwordSkill001()
    {
        UsingSkill("SecondSwordSkill001", "SecondSwordSkill002", "SecondSwordSkill003");
    }

    public void UsingSecondSwordSkill002()
    {
        UsingSkill("SecondSwordSkill002", "SecondSwordSkill001", "SecondSwordSkill003");
    }

    public void UsingSecondSwordSkill003()
    {
        UsingSkill("SecondSwordSkill003", "SecondSwordSkill001", "SecondSwordSkill002");
    }

    // Skill 3
    public void UsingThirdSwordSkill001()
    {
        UsingSkill("ThirdSwordSkill001", "ThirdSwordSkill002", "ThirdSwordSkill003");
    }

    public void UsingThirdSwordSkill002()
    {
        UsingSkill("ThirdSwordSkill002", "ThirdSwordSkill001", "ThirdSwordSkill003");
    }

    public void UsingThirdSwordSkill003()
    {
        UsingSkill("ThirdSwordSkill003", "ThirdSwordSkill001", "ThirdSwordSkill002");
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
