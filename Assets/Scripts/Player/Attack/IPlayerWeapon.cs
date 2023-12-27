using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerWeapon
{
    // tao ip cho player weapon 
    string Name;
    public void SetAnimatorLayer();
    public float Attack(Skill skill, float skillStartTime);
}
