using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContinueDamageObject : MonoBehaviour
{
    [SerializeField] private int _damage = 2;
    public int Damage { set { _damage = value; } get { return _damage; } }
    private float _startTime = -1000f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            if (Time.time - _startTime > 1f)
            {
                RuntimePlayerData.PlayerData.CurrentHP -= _damage;
                _startTime = Time.time;
            }
        }
    }
}
