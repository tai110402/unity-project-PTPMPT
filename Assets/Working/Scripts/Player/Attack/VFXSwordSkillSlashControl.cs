using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXSwordSkillSlashControl : MonoBehaviour
{
    [SerializeField] private GameObject[] _VFXNormalSkillObject;
    [SerializeField] private GameObject[] _VFXFirstSkill001Object;
    [SerializeField] private GameObject[] _VFXSecondSkill001Object;
    [SerializeField] private GameObject[] _VFXThirdSkill001Object;
    [SerializeField] private float _timeSetVFX=  0.4f;

    void SetVFXFirstNormalSwordSkillActiveTrue()
    {
        _VFXNormalSkillObject[0].SetActive(true);
        Invoke(nameof(SetVFXFirstNormalSwordSkillActiveFalse), _timeSetVFX);
    }
    void SetVFXFirstNormalSwordSkillActiveFalse()
    {
        _VFXNormalSkillObject[0].SetActive(false);
    }

    void SetVFXSecondNormalSwordSkillActiveTrue()
    {
        _VFXNormalSkillObject[1].SetActive(true);
        Invoke(nameof(SetVFXSecondNormalSwordSkillActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondNormalSwordSkillActiveFalse()
    {
        _VFXNormalSkillObject[1].SetActive(false);
    }

    void SetVFXFirstSwordSkill001ActiveTrue()
    {
        _VFXFirstSkill001Object[0].SetActive(true);
        Invoke(nameof(SetVFXFirstSwordSkill001ActiveFalse), _timeSetVFX);
    }

    void SetVFXFirstSwordSkill001ActiveFalse()
    {
        _VFXFirstSkill001Object[0].SetActive(false);
    }

    void SetVFXSecondSwordSkill001Slash1ActiveTrue()
    {
        _VFXSecondSkill001Object[0].SetActive(true);
        Invoke(nameof(SetVFXSecondSwordSkill001Slash1ActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondSwordSkill001Slash1ActiveFalse()
    {
        _VFXSecondSkill001Object[0].SetActive(false);
    }

    void SetVFXSecondSwordSkill001Slash2ActiveTrue()
    {
        _VFXSecondSkill001Object[1].SetActive(true);
        Invoke(nameof(SetVFXSecondSwordSkill001Slash2ActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondSwordSkill001Slash2ActiveFalse()
    {
        _VFXSecondSkill001Object[1].SetActive(false);
    }

    void SetVFXSecondSwordSkill001Slash3ActiveTrue()
    {
        _VFXSecondSkill001Object[2].SetActive(true);
        Invoke(nameof(SetVFXSecondSwordSkill001Slash3ActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondSwordSkill001Slash3ActiveFalse()
    {
        _VFXSecondSkill001Object[2].SetActive(false);
    }

    void SetVFXThirdSwordSkill001ActiveTrue()
    {
        _VFXThirdSkill001Object[0].SetActive(true);
        Invoke(nameof(SetVFXThirdSwordSkill001ActiveFalse), _timeSetVFX);
    }

    void SetVFXThirdSwordSkill001ActiveFalse()
    {
        _VFXThirdSkill001Object[0].SetActive(false);
    }
}
