using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGoldExpBKP : MonoBehaviour
{
    [SerializeField] private Text _expText;
    [SerializeField] private Text _goldText;
    [SerializeField] private Text _BKPText;

    // Update is called once per frame
    void Update()
    {
        _expText.text = RuntimePlayerData.PlayerData.Exp.ToString();
        _goldText.text = RuntimePlayerData.PlayerData.Gold.ToString();
        _BKPText.text = RuntimePlayerData.PlayerData.BossKillPoint.ToString();
    }
}
