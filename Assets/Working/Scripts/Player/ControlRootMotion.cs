using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRootMotion : MonoBehaviour
{
    private Animator _playerAnimator;
    private PlayerMovement _playerMovement;
    private PlayerWeaponManagement _playerWeaponManagement;
    private float _speedOnRootMotion = 0.05f;

    [SerializeField] private int _indexOfUnequipLayer = 0;
    [SerializeField] private string[] _useRootMotionUnequipAnimationArray;

    [SerializeField] private int _indexOfAxeLayer = 1;
    [SerializeField] private string[] _useRootMotionAxeAnimationArray;

    [SerializeField] private int _indexOfSwordLayer = 2;
    [SerializeField] private string[] _useRootMotionSwordAnimationArray;

    private bool _isSwordUse;
    private bool _isAxeUse;
    private bool _isUnequipUse;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerWeaponManagement = GetComponent<PlayerWeaponManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerWeaponManagement.IsSwordEquip)
        {
            for (int i = 0; i < _useRootMotionSwordAnimationArray.Length; i++)
            {
                if (_playerAnimator.GetCurrentAnimatorStateInfo(_indexOfSwordLayer).IsName(_useRootMotionSwordAnimationArray[i]))
                {
                    ApplyRootMotion();
                    _isSwordUse = true;
                    break;
                }
                _isSwordUse = false;
            }
            if (_isSwordUse == false)
            {
                ApplyCustomMotion();
            }
        }

        if (_playerWeaponManagement.IsAxeEquip)
        {
            for (int i = 0; i < _useRootMotionAxeAnimationArray.Length; i++)
            {
                if (_playerAnimator.GetCurrentAnimatorStateInfo(_indexOfAxeLayer).IsName(_useRootMotionAxeAnimationArray[i]))
                {
                    ApplyRootMotion();
                    _isAxeUse = true;
                    break;
                }
                _isAxeUse = false;
            }
            if (_isAxeUse == false)
            {
                ApplyCustomMotion();
            }
        }

        if (_playerWeaponManagement.IsUnequip)
        {
            for (int i = 0; i < _useRootMotionUnequipAnimationArray.Length; i++)
            {
                if (_playerAnimator.GetCurrentAnimatorStateInfo(_indexOfUnequipLayer).IsName(_useRootMotionUnequipAnimationArray[i]))
                {
                    ApplyRootMotion();
                    _isUnequipUse = true;
                    break;
                }
                _isUnequipUse = false;
            }
            if (_isUnequipUse == false)
            {
                ApplyCustomMotion();
            }
        }
    }

    private void  ApplyRootMotion()
    {
        _playerAnimator.applyRootMotion = true;

        if (_playerMovement.CurrentSpeed > _speedOnRootMotion)
        {
            _playerMovement.CurrentSpeed -= 0.01f;
        }
        else if (_playerMovement.CurrentSpeed < _speedOnRootMotion)
        {
            _playerMovement.CurrentSpeed += 0.01f;
        }
    }

    private void ApplyCustomMotion()
    {
        _playerAnimator.applyRootMotion = false;
    }
}
