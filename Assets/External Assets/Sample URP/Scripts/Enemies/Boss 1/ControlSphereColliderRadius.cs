using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSphereColliderRadius : MonoBehaviour
{
    private SphereCollider _sphereCollider;
    [SerializeField] float _maxRadius = 7.5f;
    [SerializeField] float _speed = 0.1f;
    // Start is called before the first frame update
    private void OnEnable()
    {
        _sphereCollider = GetComponent<SphereCollider>();
        _sphereCollider.radius = 0f;
    }

    private void OnDisable()
    {
        _sphereCollider.radius = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (_sphereCollider.radius < _maxRadius)
        {
            _sphereCollider.radius += _speed;
        }
    }
}
