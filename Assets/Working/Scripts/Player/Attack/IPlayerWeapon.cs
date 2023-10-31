using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerWeapon
{
    public void SetAnimatorLayer();
    public float Attack(Skill skill, float skillStartTime);
}
