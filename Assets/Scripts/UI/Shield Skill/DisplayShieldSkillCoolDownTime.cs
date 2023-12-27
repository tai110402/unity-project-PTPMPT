using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayShieldSkillCoolDownTime : MonoBehaviour
{
    [SerializeField] private PlayerShield _playerShield;
    [SerializeField] private Text _shieldSkillCoolDownText;

    // Update is called once per frame
    void Update()
    {
        if (_playerShield.BlockSkill != null)
        {
            float skillStartTime = _playerShield.BlockSkillStartTime;
            float timeToReset = skillStartTime + _playerShield.BlockSkill.TimeCoolDown[_playerShield.BlockSkill.Level - 1] - Time.time;
            decimal decimalTimeToReset = Math.Round((decimal)timeToReset, 2);
            if (decimalTimeToReset > 0)
            {
                _shieldSkillCoolDownText.fontSize = 16;
                _shieldSkillCoolDownText.color = Color.red;
                _shieldSkillCoolDownText.text = decimalTimeToReset.ToString();
            }
            else
            {
                _shieldSkillCoolDownText.fontSize = 14;
                _shieldSkillCoolDownText.color = Color.black;
                _shieldSkillCoolDownText.text = "Block";
            }
        }
    }
}
