using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDashCooldownTime : MonoBehaviour
{
    [SerializeField] private PlayerDash _playerDash;
    [SerializeField] private Text _dashCooldownText;


    // Update is called once per frame
    void Update()
    {
        float skillStartTime = _playerDash.DashStart;
        float timeToReset = skillStartTime + _playerDash.DashCooldown - Time.time;
        decimal decimalTimeToReset = Math.Round((decimal)timeToReset, 2);
        if (decimalTimeToReset > 0)
        {
            _dashCooldownText.fontSize = 16;
            _dashCooldownText.color = Color.red;
            _dashCooldownText.text = decimalTimeToReset.ToString();
        }
        else
        {
            _dashCooldownText.fontSize = 14;
            _dashCooldownText.color = Color.black;
            _dashCooldownText.text = "Dash";
        }
    }
}
