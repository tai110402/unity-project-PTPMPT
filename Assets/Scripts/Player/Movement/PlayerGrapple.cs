using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrapple : MonoBehaviour
{
    // References
    [Header("References")]
    [SerializeField] private Camera _cam;
    [SerializeField] private Transform _gunTip;
    [SerializeField] private LineRenderer _lineRenderer;
    [SerializeField] private LayerMask _grappleLayerMask;
    [SerializeField] private Transform _camXZDirection;

    // Setup Attributes
    [SerializeField] private float _maxDistanceCheckGrapple = 50f;
    [SerializeField] private float _maxDistanceOnGrappleMultiplier = 1.2f;
    [SerializeField] private float _maxRangeLineRenderOnGrappleMultiplier = 0.7f;
    [SerializeField] private float _grappleSpeed = 50f;
    [SerializeField] private float _grappleMoveSpeed = 20f;
    [SerializeField] private float _fakeRenderTime = 0.2f;
    [SerializeField] private string _grappleAnimationName = "Grapple";

    // Player Component
    private CharacterController _characterController;
    private Animator _playerAnimator;

    // Attributes
    private bool _isGrapplePressed;
    private bool _isMoveOnGrapplePressed;
    private bool _isGrappling;
    private Vector3 _grapplePointStart;
    private Vector3 _grapplePointTarget;
    private Vector3 _grappleDirection;
    private bool _hitSomething;
    private float _maxDistanceOnGrapple;
    private PlayerInputActions _playerInputActions;

    // Getters and Setters
    public bool IsGrapplePressed { set { _isGrapplePressed = value; } get { return _isGrapplePressed; } }
    public bool IsMoveOnGrapplePressed { set { _isMoveOnGrapplePressed = value; } get { return _isMoveOnGrapplePressed; } }

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _playerAnimator = GetComponent<Animator>();
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Enable();
    }

    private void FixedUpdate()
    {
        if (_isGrappling)
        {
            Grapple();
            Rotation(_camXZDirection.forward, 700f);
            SetLinePosition();
        } 
    }

    private void LateUpdate()
    {
        if (_isGrappling)
        {
            Rotation(_camXZDirection.forward, 700f);
        }
    }

    private void Rotation(Vector3 target, float speed)
    {
        Quaternion toRotation = Quaternion.LookRotation(target, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, speed * Time.deltaTime);
    }

    private void Grapple()
    {
        //SetLinePosition();

        if (_hitSomething)
        {
            Vector3 distance = transform.position - _grapplePointStart;
            float currentDistanceGrappleMove = distance.magnitude;

            if (currentDistanceGrappleMove < _maxDistanceOnGrapple && _isGrapplePressed)
            {
                if (currentDistanceGrappleMove > (_maxDistanceOnGrapple * _maxRangeLineRenderOnGrappleMultiplier))
                {
                    _lineRenderer.enabled = false;
                } else
                {
                    _lineRenderer.enabled = true;
                }
                _characterController.Move(_grappleDirection * _grappleSpeed * Time.deltaTime);

                Vector2 grappleMoveInput = _playerInputActions.MovementManagement.MoveOnGrapple.ReadValue<Vector2>();
                _characterController.Move((transform.up * grappleMoveInput.y) * _grappleMoveSpeed * Time.deltaTime);
            }
            else
            {
                _isGrapplePressed = false;
                _hitSomething = false;
                _isGrappling = false;
                _lineRenderer.enabled = false;
            }
        }
        else
        {
            _lineRenderer.enabled = true;
            Invoke(nameof(FakeRenderLine), _fakeRenderTime);
        }

        if (IsGrounded())
        {
            _isGrappling = false;
            _isGrapplePressed = false;
        }
    }

    // Set line position
    private void SetLinePosition()
    {
        _lineRenderer.SetPosition(0, _gunTip.position);
        _lineRenderer.SetPosition(1, _grapplePointTarget);
    }

    // Set line render
    private void SetLineRender()
    {
        _lineRenderer.enabled = true;
    }

    private void FakeRenderLine()
    {
        _lineRenderer.enabled = false;
        _isGrappling = false;
    }

    public void SetUpForGrapple()
    {
        if (_isGrapplePressed && !_isGrappling && !IsGrounded())
        {
            RaycastHit hit;
            Vector3 rayOrigin = _cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

            if (Physics.Raycast(rayOrigin, _cam.transform.forward, out hit, _maxDistanceCheckGrapple))
            {
                _grapplePointTarget = hit.point;
                _hitSomething = true;
            }
            else
            {
                _grapplePointTarget = rayOrigin + _cam.transform.forward * _maxDistanceCheckGrapple;
                _hitSomething = false;
            }

            _grappleDirection = _grapplePointTarget - transform.position;

            _maxDistanceOnGrapple = _grappleDirection.magnitude * _maxDistanceOnGrappleMultiplier;

            _grappleDirection = _grappleDirection.normalized;

            _grapplePointStart = transform.position;

            _isGrappling = true;

            _lineRenderer.enabled = true;

            for (int i = 0; i < _playerAnimator.layerCount; i++)
            {
                _playerAnimator.CrossFade(_grappleAnimationName, 0f, i);
            }
        }
        
    }

    private void FindGrapplePoint()
    {
        RaycastHit hit;
        Vector3 rayOrigin = _cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        if (Physics.Raycast(rayOrigin, _cam.transform.forward, out hit, _maxDistanceCheckGrapple))
        {
            _grapplePointTarget = hit.point;
            _hitSomething = true;
        }
        else
        {
            _grapplePointTarget = rayOrigin + _cam.transform.forward * _maxDistanceCheckGrapple;
            _hitSomething = false;
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.1f);
    }
}
