using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerWeapon
{
    // tao ip cho player weapon 
    public void SetAnimatorLayer();
    public float Attack(Skill skill, float skillStartTime);
}
