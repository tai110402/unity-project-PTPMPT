using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAxe : MonoBehaviour, IPlayerWeapon
{
    [SerializeField] private int _indexOfAxeAnimatorLayer = 1;

    private Animator _playerAnimator;

    private Skill _firstNormalSkill;
    private Skill _secondNormalSkill;
    private Skill _firstSkill;
    private Skill _secondSkill;
    private Skill _thirdSkill;

    public Skill FirstNormalSkill { set { _firstNormalSkill = value; } get { return _firstNormalSkill; } }
    public Skill SecondNormalSkill { set { _secondNormalSkill = value; } get { return _secondNormalSkill; } }
    public Skill FirstSkill { set { _firstSkill = value; } get { return _firstSkill; } }
    public Skill SecondSkill { set { _secondSkill = value; } get { return _secondSkill; } }
    public Skill ThirdSkill { set { _thirdSkill = value; } get { return _thirdSkill; } }

    private float _firstNormalSkillStartTime = -1000;
    private float _secondNormalSkillStartTime = -1000;
    private float _firstSkillStartTime = -1000f;
    private float _secondSkillStartTime = -1000f;
    private float _thirdSkillStartTime = -1000f;

    public float FirstNormalSkillStartTime { set { _firstNormalSkillStartTime = value; } get { return _firstNormalSkillStartTime; } }
    public float SecondNormalSkillStartTime { set { _secondNormalSkillStartTime = value; } get { return _secondNormalSkillStartTime; } }
    public float FirstSkillStartTime { set { _firstSkillStartTime = value; } get { return _firstSkillStartTime; } }
    public float SecondSkillStartTime { set { _secondSkillStartTime = value; } get { return _secondSkillStartTime; } }
    public float ThirdSkillStartTime { set { _thirdSkillStartTime = value; } get { return _thirdSkillStartTime; } }


    private void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSkill();
    }

    private void UpdateSkill()
    {
        Skill[] usingSkillArray = RuntimeSkillData.GetUsingSkill();
        for (int i = 0; i < usingSkillArray.Length; i++)
        {
            if (usingSkillArray[i].AnimationName.Contains("FirstAxeSkill"))
            {
                _firstSkill = usingSkillArray[i];
            }
            if (usingSkillArray[i].AnimationName.Contains("SecondAxeSkill"))
            {
                _secondSkill = usingSkillArray[i];
            }
            if (usingSkillArray[i].AnimationName.Contains("ThirdAxeSkill"))
            {
                _thirdSkill = usingSkillArray[i];
            }
            if (usingSkillArray[i].AnimationName.Contains("DefaultFirstNormalAxeSkill"))
            {
                _firstNormalSkill = usingSkillArray[i];
            }
            if (usingSkillArray[i].AnimationName.Contains("DefaultSecondNormalAxeSkill"))
            {
                _secondNormalSkill = usingSkillArray[i];
            }
        }
    }

    public void SetAnimatorLayer()
    {
        Debug.Log("Axe success ");
        for (int i = _indexOfAxeAnimatorLayer; i < _playerAnimator.layerCount; i++)
        {
            _playerAnimator.SetLayerWeight(i, 0f);
        }
        _playerAnimator.SetLayerWeight(_indexOfAxeAnimatorLayer, 1f);
    }

    public float Attack(Skill skill, float skillStartTime)
    {
        if (skill == null) return skillStartTime;

        if (Time.time - skillStartTime > skill.TimeCoolDown[skill.Level-1])
        {
            skillStartTime = Time.time;
            _playerAnimator.CrossFade(skill.AnimationName, 0f, _indexOfAxeAnimatorLayer);
        }
        return skillStartTime;
    }
}
