using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXSlashControl : MonoBehaviour
{
    [SerializeField] private GameObject[] _VFXNormalSkillObject;
    [SerializeField] private GameObject[] _VFXFirstSkill001Object;
    [SerializeField] private GameObject[] _VFXSecondSkill001Object;
    [SerializeField] private GameObject[] _VFXThirdSkill001Object;
    [SerializeField] private float _timeSetVFX=  0.4f;

    void SetVFXFirstNormalSkillActiveTrue()
    {
        _VFXNormalSkillObject[0].SetActive(true);
        Invoke(nameof(SetVFXFirstNormalSkillActiveFalse), _timeSetVFX);
    }
    void SetVFXFirstNormalSkillActiveFalse()
    {
        _VFXNormalSkillObject[0].SetActive(false);
    }

    void SetVFXSecondNormalSkillActiveTrue()
    {
        _VFXNormalSkillObject[1].SetActive(true);
        Invoke(nameof(SetVFXSecondNormalSkillActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondNormalSkillActiveFalse()
    {
        _VFXNormalSkillObject[1].SetActive(false);
    }

    void SetVFXFirstSkill001ActiveTrue()
    {
        _VFXFirstSkill001Object[0].SetActive(true);
        Invoke(nameof(SetVFXFirstSkill001ActiveFalse), _timeSetVFX);
    }

    void SetVFXFirstSkill001ActiveFalse()
    {
        _VFXFirstSkill001Object[0].SetActive(false);
    }

    void SetVFXSecondSkill001Slash1ActiveTrue()
    {
        _VFXSecondSkill001Object[0].SetActive(true);
        Invoke(nameof(SetVFXSecondSkill001Slash1ActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondSkill001Slash1ActiveFalse()
    {
        _VFXSecondSkill001Object[0].SetActive(false);
    }

    void SetVFXSecondSkill001Slash2ActiveTrue()
    {
        _VFXSecondSkill001Object[1].SetActive(true);
        Invoke(nameof(SetVFXSecondSkill001Slash2ActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondSkill001Slash2ActiveFalse()
    {
        _VFXSecondSkill001Object[1].SetActive(false);
    }

    void SetVFXSecondSkill001Slash3ActiveTrue()
    {
        _VFXSecondSkill001Object[2].SetActive(true);
        Invoke(nameof(SetVFXSecondSkill001Slash3ActiveFalse), _timeSetVFX);
    }

    void SetVFXSecondSkill001Slash3ActiveFalse()
    {
        _VFXSecondSkill001Object[2].SetActive(false);
    }

    void SetVFXThirdSkill001ActiveTrue()
    {
        _VFXThirdSkill001Object[0].SetActive(true);
        Invoke(nameof(SetVFXThirdSkill001ActiveFalse), _timeSetVFX);
    }

    void SetVFXThirdSkill001ActiveFalse()
    {
        _VFXThirdSkill001Object[0].SetActive(false);
    }
}
