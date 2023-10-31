using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuObject;
    [SerializeField] private CameraController _cameraController;

    private bool _isMainMenuDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (_isMainMenuDisplay == false)
            {
                _mainMenuObject.SetActive(true);
                _cameraController.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                _isMainMenuDisplay = true;
            }
            else
            {
                _mainMenuObject.SetActive(false);
                _cameraController.enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                _isMainMenuDisplay = false;
            }
        }
    }
}
