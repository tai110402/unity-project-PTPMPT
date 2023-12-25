using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWeapon : MonoBehaviour
{
    [SerializeField] private Transform _sword;
    [SerializeField] private Transform _swordSlot1;
    [SerializeField] private Transform _swordSlot2;

    [SerializeField] private Transform _gun;
    [SerializeField] private Transform _axeSlot1;
    [SerializeField] private Transform _axeSlot2;

    public void ArmSword()
    {
        Quaternion toRotation = Quaternion.Euler(0f, 0f, 0f);
        _sword.SetParent(_swordSlot1);
        _sword.localPosition = new Vector3(0f, 0f, 0f);
        _sword.localRotation = toRotation;
        _sword.localScale = new Vector3(1f, 1f, 1f);
    }

    public void UnArmSword()
    {
        Quaternion toRotation = Quaternion.Euler(0f, 0f, 0f);
        _sword.SetParent(_swordSlot2);
        _sword.localPosition = new Vector3(0f, 0f, 0f);
        _sword.localRotation = toRotation;
        _sword.localScale = new Vector3(1f, 1f, 1f);
    }

    public void ArmGun()
    {
        Quaternion toRotation = Quaternion.Euler(0f, 0f, 0f);
        _gun.SetParent(_axeSlot1);
        _gun.localPosition = new Vector3(0f, 0f, 0f);
        _gun.localRotation = toRotation;
        _gun.localScale = new Vector3(1f, 1f, 1f);
    }

    public void UnArmGun()
    {
        Quaternion toRotation = Quaternion.Euler(0f, 0f, 0f);
        _gun.SetParent(_axeSlot2);
        _gun.localPosition = new Vector3(0f, 0f, 0f);
        _gun.localRotation = toRotation;
        _gun.localScale = new Vector3(1f, 1f, 1f);
    }
}
