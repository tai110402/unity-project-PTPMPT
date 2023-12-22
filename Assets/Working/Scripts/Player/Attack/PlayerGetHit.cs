using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetHit : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuUI;
    private Animator _playerAnimator;
    private CharacterController _characterController;
    private PlayerWeaponManagement _playerWeaponManagement;
    private PlayerMovementManagement _playerMovementManagement;
    private Vector3 _hitDirection;
    public Vector3 HitDirection { set { _hitDirection = value; } get { return _hitDirection; } }

    // Start is called before the first frame update
    void Start()
    {
        
        _playerAnimator = GetComponent<Animator>();
        _characterController = GetComponent<CharacterController>();
        _playerWeaponManagement = GetComponent<PlayerWeaponManagement>();
        _playerMovementManagement = GetComponent<PlayerMovementManagement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("GetStrongHit") || _playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
        {
            if (_mainMenuUI.activeSelf == false)
            {
                _playerMovementManagement.enabled = false;
                _playerWeaponManagement.enabled = false;
            }
        }
        else
        {
            if (_mainMenuUI.activeSelf == false)
            {
                _playerMovementManagement.enabled = true;
                _playerWeaponManagement.enabled = true;
            }
        }

        if (_playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("GetStrongHit") || _playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
        {
            if (_playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("GetStrongHit"))
            {
                _characterController.Move(_hitDirection * 5 * Time.deltaTime);
            }
        }
    }
}
