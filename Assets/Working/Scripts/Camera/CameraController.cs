using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject _direction;
    [SerializeField] private float _senX = 15.0f;
    [SerializeField] private float _senY = 15.0f;
    [SerializeField] private float _clampYPositive = 90f;
    [SerializeField] private float _clampYNegative = -60f;
    private Vector2 _turn;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        _turn.x += Input.GetAxis("Mouse X") * Time.deltaTime * _senX;
        _turn.y += Input.GetAxis("Mouse Y") * Time.deltaTime * _senY;

        _turn.y = Mathf.Clamp(_turn.y, _clampYNegative, _clampYPositive);
        //_turn.x = Mathf.Clamp(_turn.x, -10.0f, 10.0f);

        transform.localRotation = Quaternion.Euler(-_turn.y, _turn.x, 0.0f);

        _direction.transform.localRotation = Quaternion.Euler(0.0f, _turn.x, 0.0f);
    }
}