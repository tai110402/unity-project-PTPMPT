using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // References
    [Header("References")]
    [SerializeField] private Transform _camXZDirection;

    // Setup attributes
    [Header("Attributes")]
    [SerializeField] private string _jumpAnimationName = "Jump";
    [SerializeField] private string _movementParameterName = "Movement";
    [SerializeField] private float _walkSpeed = 0.07f;
    [SerializeField] private float _runSpeed = 0.18f;
    [SerializeField] private float _rotateSpeed = 720f;
    [SerializeField] private float _jumpHeight = 2f;
    [SerializeField] private float _gravity = -20f; // -9.82f
    [SerializeField] private float _onGroundGravity = -0.1f;
    [SerializeField] private float _accelerationTime = 0.5f;
    [SerializeField] private float _minYVelocity = -15f;
    [SerializeField] private float _maxYVelocity = 100f;
    [SerializeField] private float _distanceToCheckIsGrounded = 0.1f;

    // Player Component
    private CharacterController _characterController;
    private Animator _playerAnimator;

    // Attributes
    private bool _isMovePressed;
    private bool _isJumpPressed;
    private bool _isRunPressed;
    private float _yVelocity;
    private Vector2 _moveInput;
    private PlayerInputActions _playerInputActions;
    private float _currentSpeed;
    private int _movementParameterHash;

    // Getter and Setter
    public bool IsMovePressed { set { _isMovePressed = value; } get { return _isMovePressed; } }
    public bool IsRunPressed { set { _isRunPressed = value; } get { return _isRunPressed; } }
    public bool IsJumpPressed { set { _isJumpPressed = value; } get { return _isJumpPressed; } }

    public float WalkSpeed { set { _walkSpeed = value; } get { return _walkSpeed; } }
    public float RunSpeed { set { _runSpeed = value; } get { return _runSpeed; } }
    public float CurrentSpeed { set { _currentSpeed = value; } get { return _currentSpeed; } }

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _playerAnimator = GetComponent<Animator>();
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Enable();

        _movementParameterHash = Animator.StringToHash(_movementParameterName);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (_isMovePressed && _isRunPressed)
        {
            Move(_runSpeed);

            if (_playerAnimator.GetFloat(_movementParameterHash) < 1f)
            {
                float temp = _playerAnimator.GetFloat(_movementParameterHash) + 0.05f;
                _playerAnimator.SetFloat(_movementParameterHash, temp);
            }
        }
        else if (_isMovePressed)
        {
            Move(_walkSpeed);

            if (_playerAnimator.GetFloat(_movementParameterHash) < 0.5f)
            {
                float temp = _playerAnimator.GetFloat(_movementParameterHash) + 0.5f/20f;
                _playerAnimator.SetFloat(_movementParameterHash, temp);
            }
            
            if (_playerAnimator.GetFloat(_movementParameterHash) > 0.5f)
            {
                float temp = _playerAnimator.GetFloat(_movementParameterHash) - 0.5f/30f;
                _playerAnimator.SetFloat(_movementParameterHash, temp);
            }
        } else
        {
            if (_currentSpeed > 0f)
            {
                _currentSpeed = 0f;
            }

            _playerAnimator.SetFloat(_movementParameterHash, 0.0f);

            Rotation(_camXZDirection.forward, _rotateSpeed);
        }

        if (_isJumpPressed && IsGrounded())
        {
            Jump();
            for (int i = 0; i < _playerAnimator.layerCount; i++)
            {
                _playerAnimator.CrossFade(_jumpAnimationName, 0f, i);
            }
        }
        
        Gravity();
        //Debug.Log(_currentSpeed);

        // Handel falling animation  
        if (!Physics.Raycast(transform.position, Vector3.down, _jumpHeight))
        {
            _playerAnimator.SetFloat(_movementParameterHash, -0.5f);
        }
    }

    private void Move(float moveSpeed)
    {
        if (_currentSpeed < moveSpeed)
        {
            _currentSpeed += moveSpeed / (_accelerationTime * 60f);

            if ( _currentSpeed > moveSpeed)
            {
                _currentSpeed = moveSpeed;
            }
        }
        else if (_currentSpeed > moveSpeed)
        {
            _currentSpeed -= moveSpeed / (_accelerationTime * 60f);

            if (_currentSpeed < moveSpeed)
            {
                _currentSpeed = moveSpeed;
            }
        } 

        _moveInput = _playerInputActions.MovementManagement.Movement.ReadValue<Vector2>();
        Rotation(_camXZDirection.right * _moveInput.x + _camXZDirection.forward * _moveInput.y, _rotateSpeed);
        _characterController.Move((_moveInput.x * _camXZDirection.right + _moveInput.y * _camXZDirection.forward) * _currentSpeed);
    }

    private void Jump()
    {
        _yVelocity = Mathf.Sqrt(-2 * _gravity * _jumpHeight);
    }

    private void Gravity()
    {
        if (IsGrounded() && !_isJumpPressed)
        {
            _yVelocity = _onGroundGravity;
        }
        _yVelocity = _yVelocity + _gravity * Time.deltaTime;
        _yVelocity = Mathf.Clamp(_yVelocity, _minYVelocity, _maxYVelocity);
        float YMoveDistance = _yVelocity * Time.deltaTime + 0.5f * _gravity * Time.deltaTime * Time.deltaTime;
        _characterController.Move(new Vector3(0f, YMoveDistance, 0f));
        //Debug.Log(_yVelocity);
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, _distanceToCheckIsGrounded);
    }

    private void Rotation(Vector3 target, float speed)
    {
        Quaternion toRotation = Quaternion.LookRotation(target, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, speed * Time.deltaTime);
    }

    private void Animation()
    {
        
    }
}
