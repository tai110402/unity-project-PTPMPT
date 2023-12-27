using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosingShieldSkill : MonoBehaviour
{
    [SerializeField] private Image _firstNormalShieldSkillBackGround;
    [SerializeField] private Image _secondNormalShieldSkillBackGround;

    // Update is called once per frame
    void Update()
    {
        // Normal Skill
        UpdateButtonColor("DefaultBlockSkill001", _firstNormalShieldSkillBackGround);
        UpdateButtonColor("DefaultBlockSkill002", _secondNormalShieldSkillBackGround);
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

    // Normal Skill
    public void UsingDefaultBlockSkill001()
    {
        UsingSkill("DefaultBlockSkill001", "DefaultBlockSkill002");
    }

    public void UsingDefaultBlockSkill002()
    {
        UsingSkill("DefaultBlockSkill002", "DefaultBlockSkill001");
    }

    private void UsingSkill(string usingSkillName, string unUsingSkillName1)
    {
        if (RuntimeSkillData.SkillDictionary[usingSkillName].IsUnlocked == true)
        {
            RuntimeSkillData.SkillDictionary[usingSkillName].IsUsing = true;
            RuntimeSkillData.SkillDictionary[unUsingSkillName1].IsUsing = false;
        }
    }
}
