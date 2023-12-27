using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    [SerializeField] private GameObject _shieldGameObject;
    [SerializeField] private GameObject _shieldColliderGameObject;

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

        if (_blockSkill != null)
        {
            for (int i = 0; i < _playerAnimator.layerCount; i++)
            {
                if (_playerAnimator.GetCurrentAnimatorStateInfo(i).IsName(_blockSkill.AnimationName))
                {
                    _shieldGameObject.SetActive(true);
                }
                else
                {
                    _shieldGameObject.SetActive(false);
                }
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
                StartCoroutine(ShieldColliderControl());

                blockStartTime = Time.time;
                for (int i = 0; i < _playerAnimator.layerCount; i++)
                {
                    _playerAnimator.CrossFade(blockSkill.AnimationName, 0f, i);
                }
            }
        }
        return blockStartTime;
    }
    IEnumerator ShieldColliderControl()
    {
        _shieldGameObject.SetActive(true);
        _shieldColliderGameObject.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        _shieldGameObject.SetActive(false);
        _shieldColliderGameObject.SetActive(false);
    }
}
