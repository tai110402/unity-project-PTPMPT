using System;

[System.Serializable]
public class Skill
{
    public string AnimationName;
    public float[] TimeCoolDown;
    public SkillSlash[] SlashArray;
    public bool IsUnlocked;
    public bool IsUsing;
    public int Level = 1;
    public int MaxLevel;
    public int[] ExpToUpgradeArray;
    public Skill()
    {
        //SlashDamage = new float[1];
    }

    public Skill(int numberOfSlashs)
    {
        //SlashDamage = new float[numberOfSlashs];
    }

    public void AddSlashDamage(float newSlashDame)
    {
        //Array.Resize(ref SlashDamage, SlashDamage.Length + 1);
        //SlashDamage[SlashDamage.Length - 1] = newSlashDame;
    }
}
