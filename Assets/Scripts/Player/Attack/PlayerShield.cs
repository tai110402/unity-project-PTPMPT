using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    //[SerializeField] private float _blockTime;

    private Animator _playerAnimator;

    private Skill _blockSkill;
    private float _blockSkillStartTime = -1000f;

    public Skill BlockSkill { set { _blockSkill = value; } get { return _blockSkill; } }
    public float BlockSkillStartTime { set { _blockSkillStartTime = value; } get { return _blockSkillStartTime; } }

    private void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Skill[] skillArray = RuntimeSkillData.GetUsingSkill();
        for (int i = 0; i < skillArray.Length; i++)
        {
            if (skillArray[i].AnimationName.Contains("DefaultBlockSkill"))
            {
                _blockSkill = skillArray[i];
            }
        }
    }

    public float Block(Skill blockSkill, float blockStartTime)
    {
        if (blockSkill == null) return blockStartTime;

        if (Time.time - blockStartTime > blockSkill.TimeCoolDown[blockSkill.Level-1])
        {
            blockStartTime = Time.time;
            for (int i = 0; i < _playerAnimator.layerCount; i++)
            {
                _playerAnimator.CrossFade(blockSkill.AnimationName, 0f, i);
            }
        }
        return blockStartTime;
    }
}
