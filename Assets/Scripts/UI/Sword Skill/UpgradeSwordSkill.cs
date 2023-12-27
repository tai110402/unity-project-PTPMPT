using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSwordSkill : MonoBehaviour
{
    private void Upgrade(string skillName)
    {
        Skill skill = RuntimeSkillData.SkillDictionary[skillName];
        PlayerData playerData = RuntimePlayerData.PlayerData;
        if (skill.IsUnlocked == true && playerData.Exp >= skill.ExpToUpgradeArray[skill.Level - 1] && skill.Level < skill.MaxLevel)
        {
            if (skill.Level == skill.MaxLevel - 1)
            {
                if (playerData.BossKillPoint >= 1)
                {
                    playerData.Exp -= skill.ExpToUpgradeArray[skill.Level - 1];
                    playerData.BossKillPoint -= 1;
                    skill.Level += 1;
                }
            }
            else
            {
                playerData.Exp -= skill.ExpToUpgradeArray[skill.Level - 1];
                Debug.Log(skill.Level + "  " + skill.ExpToUpgradeArray[skill.Level - 1]);
                skill.Level += 1;
            }
        }
    }

    // Normal Skill
    public void DefaultFirstNormalSwordSkillUpgrade()
    {
        Upgrade("DefaultFirstNormalSwordSkill");
    }

    public void DefaultSecondNormalSwordSkillUpgrade()
    {
        Upgrade("DefaultSecondNormalSwordSkill");
    }

    // Skill 1
    public void FirstSwordSkill001Upgrade()
    {
        Upgrade("FirstSwordSkill001");
    }

    public void FirstSwordSkill002Upgrade()
    {
        Upgrade("FirstSwordSkill002");
    }

    public void FirstSwordSkill003Upgrade()
    {
        Upgrade("FirstSwordSkill003");
    }

    // Skill 2
    public void SecondSwordSkill001Upgrade()
    {
        Upgrade("SecondSwordSkill001");
    }

    public void SecondSwordSkill002Upgrade()
    {
        Upgrade("SecondSwordSkill002");
    }

    public void SecondSwordSkill003Upgrade()
    {
        Upgrade("SecondSwordSkill003");
    }

    // Skill 3
    public void ThirdSwordSkill001Upgrade()
    {
        Upgrade("ThirdSwordSkill001");
    }

    public void ThirdSwordSkill002Upgrade()
    {
        Upgrade("ThirdSwordSkill002");
    }

    public void ThirdSwordSkill003Upgrade()
    {
        Upgrade("ThirdSwordSkill003");
    }
}
