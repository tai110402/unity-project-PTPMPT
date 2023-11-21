using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovementManagement : MonoBehaviour
{
    // Player Component
    private PlayerMovement _playerMovement;
    private PlayerDash _playerDash;
    private PlayerClimb _playerClimb;
    private PlayerGrapple _playerGrapple;

    private PlayerInputActions _playerInputActions;

    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerDash = GetComponent<PlayerDash>();
        _playerClimb = GetComponent<PlayerClimb>();
        _playerGrapple = GetComponent<PlayerGrapple>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _playerInputActions.MovementManagement.Run.started += OnRunStart;
        _playerInputActions.MovementManagement.Run.canceled += OnRunCancel;

        _playerInputActions.MovementManagement.Jump.started += OnJumpStart;
        _playerInputActions.MovementManagement.Jump.canceled += OnJumpCancel;

        _playerInputActions.MovementManagement.Movement.started += OnMoveStart;
        _playerInputActions.MovementManagement.Movement.canceled += OnMoveCancel;

        _playerInputActions.MovementManagement.Grapple.started += OnGrappleStart;
        _playerInputActions.MovementManagement.Grapple.canceled += OnGrappleCancel;

        _playerInputActions.MovementManagement.MoveOnGrapple.started += OnGrappleMoveStart;
        _playerInputActions.MovementManagement.MoveOnGrapple.canceled += OnGrappleMoveCancel;

        _playerInputActions.MovementManagement.Dash.started += OnDashStart;
        _playerInputActions.MovementManagement.Dash.canceled += OnDashCancel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnRunStart(InputAction.CallbackContext context)
    {
        _playerMovement.IsRunPressed = true;
    }

    private void OnRunCancel(InputAction.CallbackContext context)
    {
        _playerMovement.IsRunPressed = false;
    }

    private void OnJumpStart(InputAction.CallbackContext context)
    {
        _playerMovement.IsJumpPressed = true;
    }

    private void OnJumpCancel(InputAction.CallbackContext context)
    {
        _playerMovement.IsJumpPressed = false;
    }

    private void OnMoveStart(InputAction.CallbackContext context)
    {
        _playerMovement.IsMovePressed = true;
    }

    private void OnMoveCancel(InputAction.CallbackContext context)
    {
        _playerMovement.IsMovePressed = false;
    }

    private void OnGrappleStart(InputAction.CallbackContext context)
    {
        _playerGrapple.IsGrapplePressed = true;
        _playerGrapple.SetUpForGrapple();
    }

    private void OnGrappleCancel(InputAction.CallbackContext context)
    {
        _playerGrapple.IsGrapplePressed = false;
    }

    private void OnGrappleMoveStart(InputAction.CallbackContext context)
    {
        _playerGrapple.IsMoveOnGrapplePressed = true;
    }

    private void OnGrappleMoveCancel(InputAction.CallbackContext context)
    {
        _playerGrapple.IsMoveOnGrapplePressed = false;
    }

    private void OnDashStart(InputAction.CallbackContext context)
    {
        _playerDash.IsDashPressed = true;
    }

    private void OnDashCancel(InputAction.CallbackContext context)
    {
        _playerDash.IsDashPressed = false;
    }

    private void OnEnable()
    {
        _playerInputActions.Enable();
    }

    private void OnDisable()
    {
        _playerInputActions.Disable();
    }
}
