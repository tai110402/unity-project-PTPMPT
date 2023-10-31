using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplaySwordSkillCoolDownTime : MonoBehaviour
{
    [SerializeField] private PlayerSword _playerSword;
    [SerializeField] private Text _firstSwordSkillCoolDownText;
    [SerializeField] private Text _secondSwordSkillCoolDownText;
    [SerializeField] private Text _thirdSwordSkillCoolDownText;

    // Update is called once per frame
    void Update()
    {
        if (_playerSword.FirstSkill != null)
        {
            float skillStartTime = _playerSword.FirstSkillStartTime;
            float timeToReset = skillStartTime + _playerSword.FirstSkill.TimeCoolDown[_playerSword.FirstSkill.Level - 1] - Time.time;
            decimal decimalTimeToReset = Math.Round((decimal)timeToReset, 2);
            if (decimalTimeToReset > 0)
            {
                _firstSwordSkillCoolDownText.fontSize = 16;
                _firstSwordSkillCoolDownText.color = Color.red;
                _firstSwordSkillCoolDownText.text = decimalTimeToReset.ToString();
            } else
            {
                _firstSwordSkillCoolDownText.fontSize = 14;
                _firstSwordSkillCoolDownText.color = Color.black;
                _firstSwordSkillCoolDownText.text = "Q";
            }
        }

        if (_playerSword.SecondSkill != null)
        {
            float skillStartTime = _playerSword.SecondSkillStartTime;
            float timeToReset = skillStartTime + _playerSword.SecondSkill.TimeCoolDown[_playerSword.SecondSkill.Level - 1] - Time.time;
            decimal decimalTimeToReset = Math.Round((decimal)timeToReset, 2);
            if (decimalTimeToReset > 0)
            {
                _secondSwordSkillCoolDownText.fontSize = 16;
                _secondSwordSkillCoolDownText.color = Color.red;
                _secondSwordSkillCoolDownText.text = decimalTimeToReset.ToString();
            }
            else
            {
                _secondSwordSkillCoolDownText.fontSize = 14;
                _secondSwordSkillCoolDownText.color = Color.black;
                _secondSwordSkillCoolDownText.text = "E";
            }
        }

        if (_playerSword.ThirdSkill != null)
        {
            float skillStartTime = _playerSword.ThirdSkillStartTime;
            float timeToReset = skillStartTime + _playerSword.ThirdSkill.TimeCoolDown[_playerSword.ThirdSkill.Level - 1] - Time.time;
            decimal decimalTimeToReset = Math.Round((decimal)timeToReset, 2);
            if (decimalTimeToReset > 0)
            {
                _thirdSwordSkillCoolDownText.fontSize = 16;
                _thirdSwordSkillCoolDownText.color = Color.red;
                _thirdSwordSkillCoolDownText.text = decimalTimeToReset.ToString();
            }
            else
            {
                _thirdSwordSkillCoolDownText.fontSize = 14;
                _thirdSwordSkillCoolDownText.color = Color.black;
                _thirdSwordSkillCoolDownText.text = "R";
            }
        }
    }
}
