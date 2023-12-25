using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeaponManagement : MonoBehaviour
{
    //References
    [Header("References")]
    [SerializeField] private PlayerSword _playerSword;
    [SerializeField] private PlayerAxe _playerAxe;
    [SerializeField] private PlayerShield _playerShield;
    [SerializeField] private float _timeWaitForCalculateNumberOfClicks = 0.2f;

    private PlayerInputActions _playerInputActions;
    private Animator _playerAnimator;
    private bool _isUnequip;
    private bool _isSwordEquip;
    private bool _isAxeEquip;

    private float _timeNormalClicked;
    private int _numberOfClicks;

    public bool IsUnequip { get { return _isUnequip; } }
    public bool IsSwordEquip { get { return _isSwordEquip; } }
    public bool IsAxeEquip { get { return _isAxeEquip; } }

    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();

        _playerAnimator = GetComponent<Animator>();
        _isUnequip = true;
    }

    private void OnEnable()
    {
        _playerInputActions.AttackManagement.Enable();
    }

    private void OnDisable()
    {
        _playerInputActions.AttackManagement.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerInputActions.AttackManagement.NormalSkill.started += OnNormalSkillStart;
        _playerInputActions.AttackManagement.FirstSkill.started += OnFirstSkillStart;
        _playerInputActions.AttackManagement.SecondSkill.started += OnSecondSkillStart;
        _playerInputActions.AttackManagement.ThirdSkill.started += OnThirdSkillStart;
        _playerInputActions.AttackManagement.BlockSkill.started += OnBlockSkillStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _isUnequip = true;
            _isAxeEquip = false;
            _isSwordEquip = false;
            for (int i = 1; i < _playerAnimator.layerCount; i++)
            {
                _playerAnimator.SetLayerWeight(i, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _isUnequip = false;
            _isAxeEquip = true;
            _isSwordEquip = false;
            _playerAxe.SetAnimatorLayer();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _isUnequip = false;
            _isAxeEquip = false;
            _isSwordEquip = true;
            _playerSword.SetAnimatorLayer();
        }
    }

    private void OnNormalSkillStart(InputAction.CallbackContext context)
    {
        if (_timeNormalClicked + 0.2f > Time.time)
        {
            _numberOfClicks += 1;
        }
        else
        {
            _numberOfClicks = 1;
            _timeNormalClicked = Time.time;
        }

        if (_isAxeEquip)
        {
            if (_numberOfClicks == 1)
            {
                Invoke(nameof(WaitForCalculateNumberOfClicksForAxe), _timeWaitForCalculateNumberOfClicks);
            }
            else if (_numberOfClicks == 2)
            {
                CancelInvoke(nameof(WaitForCalculateNumberOfClicksForAxe));
                _playerAxe.SecondNormalSkillStartTime = _playerAxe.Attack(_playerAxe.SecondNormalSkill, _playerAxe.SecondNormalSkillStartTime);
            }
        }
        else if (_isSwordEquip)
        {
            if (_numberOfClicks == 1)
            {
                Invoke(nameof(WaitForCalculateNumberOfClicksForSword), _timeWaitForCalculateNumberOfClicks);
            }
            else if (_numberOfClicks == 2)
            {
                CancelInvoke(nameof(WaitForCalculateNumberOfClicksForSword));
                _playerSword.SecondNormalSkillStartTime = _playerSword.Attack(_playerSword.SecondNormalSkill, _playerSword.SecondNormalSkillStartTime);
            }
        }
    }

    private void WaitForCalculateNumberOfClicksForSword()
    {
        _playerSword.FirstNormalSkillStartTime = _playerSword.Attack(_playerSword.FirstNormalSkill, _playerSword.FirstNormalSkillStartTime);

    }

    private void WaitForCalculateNumberOfClicksForAxe()
    {
        _playerAxe.FirstNormalSkillStartTime = _playerAxe.Attack(_playerAxe.FirstNormalSkill, _playerAxe.FirstNormalSkillStartTime);

    }

    private void OnFirstSkillStart(InputAction.CallbackContext context)
    {
        if (_isAxeEquip)
        {
            _playerAxe.FirstSkillStartTime = _playerAxe.Attack(_playerAxe.FirstSkill, _playerAxe.FirstSkillStartTime);
        } 
        else if (_isSwordEquip)
        {
            //_playerSword.FirstSkill();
            _playerSword.FirstSkillStartTime = _playerSword.Attack(_playerSword.FirstSkill, _playerSword.FirstSkillStartTime);
        }
    }

    private void OnSecondSkillStart(InputAction.CallbackContext context)
    {
        if (_isAxeEquip)
        {
            _playerAxe.SecondSkillStartTime = _playerAxe.Attack(_playerAxe.SecondSkill, _playerAxe.SecondSkillStartTime);
        }
        else if (_isSwordEquip)
        {
            //_playerSword.FirstSkill();
            _playerSword.SecondSkillStartTime = _playerSword.Attack(_playerSword.SecondSkill, _playerSword.SecondSkillStartTime);
        }
    }

    private void OnThirdSkillStart(InputAction.CallbackContext context)
    {
        if (_isAxeEquip)
        {
            _playerAxe.ThirdSkillStartTime = _playerAxe.Attack(_playerAxe.ThirdSkill, _playerAxe.ThirdSkillStartTime);
        }
        else if (_isSwordEquip)
        {
            //_playerSword.FirstSkill();
            _playerSword.ThirdSkillStartTime = _playerSword.Attack(_playerSword.ThirdSkill, _playerSword.ThirdSkillStartTime);
        }
    }

    private void OnBlockSkillStart(InputAction.CallbackContext context)
    {
        _playerShield.BlockSkillStartTime = _playerShield.Block(_playerShield.BlockSkill, _playerShield.BlockSkillStartTime);
    }
}
