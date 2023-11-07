using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageObject : MonoBehaviour
{
    [SerializeField] private int _damage = 3;
    public int Damage { set { _damage = value; } get { return _damage; } }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            RuntimePlayerData.PlayerData.CurrentHP -= _damage;
            Debug.Log("damge");
        }
    }
}
