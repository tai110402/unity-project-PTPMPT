using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _spawnTransform;
    [SerializeField] private Transform _targetTransform;

    [SerializeField] private float _idleDistance = 20f;
    [SerializeField] private float _chaseDistance = 15f;
    [SerializeField] private float _attackDistance = 1f;

    [SerializeField] private float _maxSkillJump = 3f;
    [SerializeField] private float _minSkillJump = 2.5f;

    private Animator _enemyAnimator;
    private float _currentDistanceToTarget;

    private NavMeshAgent _navAgent;
    
    // Start is called before the first frame update
    void Start()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _enemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentDistanceToTarget = CurrentDistance();

        if (_currentDistanceToTarget < _maxSkillJump && _currentDistanceToTarget > _minSkillJump)
        {
            _enemyAnimator.SetTrigger("JumpAttack");
        }

        if (_currentDistanceToTarget < _attackDistance)
        {
            Attack();
            Debug.Log("Attack");
        } 
        else if (_currentDistanceToTarget < _chaseDistance)
        {
            Chase();
            Debug.Log("chase");
        } 
        else if (_currentDistanceToTarget < _idleDistance)
        {
            Idle();
            Debug.Log("Idle");
        }
    }

    private float CurrentDistance()
    {
        Vector3 currenDistance = transform.position - _targetTransform.position;
        return currenDistance.magnitude;
    }

    private void Idle()
    {
        
    }

    private void Chase()
    {
        _navAgent.SetDestination(_targetTransform.position);
        _enemyAnimator.SetBool("Walk", true);
    }

    private void Attack()
    {
        _navAgent.SetDestination(transform.position);
        _enemyAnimator.SetTrigger("NormalAttack");
    }
}
