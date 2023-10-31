using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMenu : MonoBehaviour
{
    [SerializeField] private GameObject _shield;
    [SerializeField] private GameObject _axe;
    [SerializeField] private GameObject _sword;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShieldClick()
    {
        _shield.SetActive(true);
        _axe.SetActive(false);
        _sword.SetActive(false);
    }

    public void OnAxeClick()
    {
        _shield.SetActive(false);
        _axe.SetActive(true);
        _sword.SetActive(false);
    }

    public void OnSwordClick()
    {
        _shield.SetActive(false);
        _axe.SetActive(false);
        _sword.SetActive(true);
    }
}
