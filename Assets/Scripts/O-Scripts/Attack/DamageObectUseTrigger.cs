using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObectUseTrigger : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private string _skillName;
    [SerializeField] private int _indexOfSlash;
    [SerializeField] private int _indexOfWeapon;
    
    private void OnTriggerEnter(Collider other)
    {
        DamageableObject damgeableObject = other.GetComponent<DamageableObject>();
        Animator enemyAnimator = other.GetComponent<Animator>();

        if (other.gameObject.tag.Contains("Enemy") || other.gameObject.tag.Contains("Boss"))
        {
            if (enemyAnimator != null)
            {
                enemyAnimator.CrossFade("EnemyGetHit", 0f);
            }

            if (damgeableObject != null)
            {
                Skill skill = RuntimeSkillData.SkillDictionary[_skillName];
                float skillDamage = skill.SlashArray[skill.Level - 1].Slash[_indexOfSlash];

                WeaponData weaponData = RuntimeEquipmentData.EquipmentData.WeaponDataArray[_indexOfWeapon];
                int weaponDamage = weaponData.Damage[weaponData.Level - 1];

                _damage = (int)(skillDamage * weaponDamage);

                damgeableObject.Damage(_damage);

                Debug.Log("He so Skill: " + skillDamage + ", WeaponDamage: " + weaponDamage);
            }
        }

        
    }
}
