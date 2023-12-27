using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaderMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _equipment;
    [SerializeField] private GameObject _skill;
    [SerializeField] private GameObject _codex;
    [SerializeField] private GameObject _settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEquipmentClick()
    {
        _equipment.SetActive(true);
        _skill.SetActive(false);
        _codex.SetActive(false);
        _settings.SetActive(false);
    }

    public void OnSkillClick()
    {
        _equipment.SetActive(false);
        _skill.SetActive(true);
        _codex.SetActive(false);
        _settings.SetActive(false);
    }

    public void OnCodexClick()
    {
        _equipment.SetActive(false);
        _skill.SetActive(false);
        _codex.SetActive(true);
        _settings.SetActive(false);
    }

    public void OnSettingsClick()
    {
        _equipment.SetActive(false);
        _skill.SetActive(false);
        _codex.SetActive(false);
        _settings.SetActive(true);
    }
}
