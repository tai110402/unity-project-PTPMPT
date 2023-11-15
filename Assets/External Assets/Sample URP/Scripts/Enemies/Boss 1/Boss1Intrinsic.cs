using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Intrinsic : MonoBehaviour
{
    private Vector3 _playerPosition;
    private Vector3 _spawnPoint;
    private float _timeSpawn;
    [SerializeField] private float _lifeTime = 20f;

    // Start is called before the first frame update
    void Start()
    {
        _spawnPoint = transform.position;
        _timeSpawn = Time.time;
        _playerPosition = GameObject.FindWithTag("Player").transform.position + new Vector3(0f, 0.8f, 0f);
    }

    private void Update()
    {
        if (Time.time - _timeSpawn > _lifeTime)
        {
            GameObject.Destroy(gameObject);
            Debug.Log("time destou");
        }
    }

    public void ActiveIntrinsicSkill()
    {
        StartCoroutine(ExcuteIntrinsic());
    }

    IEnumerator ExcuteIntrinsic()
    {
        Vector3 c;
        c = Vector3.Lerp(_spawnPoint, _playerPosition, 0.7f);
        float distance = (_playerPosition - _spawnPoint).magnitude;
        c += (Vector3.up * Random.Range(distance / 5, distance / 3) + transform.right * Random.Range(-distance/3, distance / 3));
        float t = 0f;
        while (t <= 1f)
        {
            transform.position = Evaluate(t, c);
            transform.up = Evaluate(t + 0.001f, c) - transform.position;
            t += 0.02f;
            yield return new WaitForSeconds(0.01f);
        }
        // destroy this
    }

    private Vector3 Evaluate(float t, Vector3 c)
    {
        _playerPosition = GameObject.FindWithTag("Player").transform.position + new Vector3(0f, 0.8f, 0f);
        Vector3 ac = Vector3.Lerp(_spawnPoint, c, t);
        Vector3 cb = Vector3.Lerp(c, _playerPosition, t);
        Vector3 acb = Vector3.Lerp(ac, cb, t);
        return acb;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            Transform VFX = transform.GetChild(0);
            VFX.gameObject.SetActive(true);
            GameObject.Destroy(gameObject, 0.1f);
        }
    }
}
