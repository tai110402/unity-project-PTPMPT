using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private Transform _healthBarCanvas;
    private Image _healthBarSprite;
    private DamageableObject _damageableObject;

    private Camera _cam;

    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
        _damageableObject = GetComponentInParent<DamageableObject>();
        _healthBarSprite = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _healthBarCanvas.rotation = Quaternion.LookRotation(_healthBarCanvas.position - _cam.transform.position);
        _healthBarSprite.fillAmount = (_damageableObject.CurrentHealth * 1f) / _damageableObject.MaxHealth;
    }
    
}
