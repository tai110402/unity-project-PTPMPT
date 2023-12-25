using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShieldSkill : MonoBehaviour
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
    public void DefaultBlockSkill001Upgrade()
    {
        Upgrade("DefaultBlockSkill001");
    }

    public void DefaultBlockSkill002Upgrade()
    {
        Upgrade("DefaultBlockSkill002");
    }
}
