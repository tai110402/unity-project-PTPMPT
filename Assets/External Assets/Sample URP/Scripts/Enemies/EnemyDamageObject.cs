using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageObject : MonoBehaviour
{
    [SerializeField] private int _damage = 3;
    [SerializeField] private string _enemyGameObjectName = "Boss1";
    [SerializeField] private string _playerGetHitAnimationName = "GetStrongHit";
    [SerializeField] private bool _turnOnGetHitAnimation = false;
    public int Damage { set { _damage = value; } get { return _damage; } }
    public bool TurnOnGetHitAnimation { set { _turnOnGetHitAnimation = value; } get { return _turnOnGetHitAnimation; } }

    private void Awake()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            RuntimePlayerData.PlayerData.CurrentHP -= _damage;
            Debug.Log("damge");

            if (_turnOnGetHitAnimation && (_playerGetHitAnimationName == "GetStrongHit" || _playerGetHitAnimationName == "GetHit"))
            {
                GameObject playerGameObject = GameObject.FindWithTag("Player");
                Animator x = playerGameObject.GetComponent<Animator>();
                for (int i = 0; i < x.layerCount; i++)
                {
                    x.CrossFade(_playerGetHitAnimationName, 0f, i);
                }
                if (_playerGetHitAnimationName == "GetStrongHit")
                {
                    playerGameObject.GetComponent<PlayerGetHit>().HitDirection = (playerGameObject.transform.position - GameObject.FindWithTag(_enemyGameObjectName).transform.position).normalized;

                } else if (_playerGetHitAnimationName == "GetHit")
                {
                    playerGameObject.GetComponent<PlayerGetHit>().HitDirection = 0.1f * (playerGameObject.transform.position - GameObject.FindWithTag(_enemyGameObjectName).transform.position).normalized;

                }
            }
        }
    }
}
