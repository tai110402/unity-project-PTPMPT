using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    [SerializeField] private int _damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        DamageableObject damageableObject = collision.collider.GetComponent<DamageableObject>();

        if (damageableObject != null)
        {
            damageableObject.Damage(_damage);
        }

        //gameObject.SetActive(false);
    }
}
