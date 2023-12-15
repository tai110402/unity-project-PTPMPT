using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class SkillData
{
    public Skill[] Skills;

    public SkillData()
    {
        Skills = new Skill[0];
    }

    public SkillData(int numberOfSkills)
    {
        Skills = new Skill[numberOfSkills];
        for (int i = 0; i < numberOfSkills; i++)
        {
            Skills[i] = new Skill();
        }
    }

    public void AddSkill(Skill newSkill)
    {
        Array.Resize(ref Skills, Skills.Length + 1);
        Skills[Skills.Length - 1] = newSkill;
    }
}
