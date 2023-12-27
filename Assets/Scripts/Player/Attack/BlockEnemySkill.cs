using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEnemySkill : MonoBehaviour
{
    [SerializeField] private string[] _destroyGameObjectTagArray;
    [SerializeField] private float _hitForce = 0.01f;
    [SerializeField] private float _duration = 0.5f;
    [SerializeField] private GameObject _playerGameObject;
    private float grade = 0;

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < _destroyGameObjectTagArray.Length; i++)
        {
            if (other.CompareTag(_destroyGameObjectTagArray[i]))
            {
                Debug.log("check");
                GameObject.Destroy(other.gameObject);
                StartCoroutine(ApplyHitForce(_duration));
                //GameObject.FindWithTag("Player").GetComponent<Animator>().CrossFade("BlockImpact", 0f, 1);
            }
        }

        if (other.CompareTag("Enemy"))
        {
            Debug.log("asdf");
            other.GetComponentInParent<Animator>().CrossFade("BlockedReaction", 0f);
        }
    }

    IEnumerator ApplyHitForce(float duration)
    {
        float startTime = Time.time;
        while (Time.time - startTime < duration)
        {
            _playerGameObject.GetComponent<CharacterController>().Move(_playerGameObject.transform.forward * -1f * _hitForce);
            yield return new WaitForSeconds(0.005f);
        }
    }
}
