using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GuideDisplay : MonoBehaviour
{
    [SerializeField] private GameObject _guideGameObject;
    private PlayerInputActions _playerInputActions;
    private bool _isGuideMenuDisplay;

    // Start is called before the first frame update
    void Start()
    {
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.UI.Guide.Enable();

        _playerInputActions.UI.Guide.started += OnGuideButtonStart;
    }

    private void OnGuideButtonStart(InputAction.CallbackContext context)
    {
        if (_isGuideMenuDisplay == false)
        {
            _isGuideMenuDisplay = true;
            _guideGameObject.SetActive(true);
        }
        else
        {
            _isGuideMenuDisplay = false;
            _guideGameObject.SetActive(false);
        }
    }
}
