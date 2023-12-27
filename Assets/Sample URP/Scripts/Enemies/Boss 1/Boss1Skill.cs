using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Skill : MonoBehaviour
{

    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Animator _boss1Animator;

    // Intrinsic <=> Skill 3
    [SerializeField] private GameObject _intrinsic;
    [SerializeField] private float _intrinsicCooldownTime = 2f;
    [SerializeField] private int _maxNumberOfIntrinsic = 7;
    [SerializeField] private int _intrinsicDamage = 3;
    private float _intrinsicSkillStartTime;
    private List<GameObject> _intrinsicList = new List<GameObject>();

    public List<GameObject> IntrinsicList { get { return _intrinsicList; } }

    // DefaultRangeSkill
    [SerializeField] private GameObject _defaultRangeSkillProjectile;
    [SerializeField] private Transform _defaultRangeSkillSpawnPoint;
    [SerializeField] private float _defaultRangeSkillCooldownTime = 3f;
    [SerializeField] private float _defaultRangeSkillSpeed = 3f;
    private float _defaultRangeSkillStartTime;

    // Skill 1
    [SerializeField] private GameObject _firstSkillVFX;
    [SerializeField] private float _firstSkillDuration = 10f;
    [SerializeField] private float _firstSkillCooldownTime = 20f;
    private float _firstSkillStartTime = -1000f;

    // Skill 2
    [SerializeField] private GameObject _secondSkillVFX;
    [SerializeField] private float _secondSkillCooldownTime = 10f;
    private float _secondSkillStartTime = -1000f;

    // Start is called before the first frame update
    void Start()
    {
        _boss1Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Intrinsic();

        if (Input.GetKeyDown(KeyCode.V))
        {
            StartCoroutine(ThirdSkill());
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(DefaultRangeSkill());
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            StartCoroutine(FirstSkill());
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            StartCoroutine(SecondSkill());
        }
    }

    // Boss1 intrinsic
    private void Intrinsic()
    {
        foreach(GameObject gameObject in _intrinsicList)
        {
            if (gameObject == null)
            {
                _intrinsicList.Remove(gameObject);
                _intrinsicSkillStartTime = Time.time;
                break;
            }
        }

        if (Time.time - _intrinsicSkillStartTime > _intrinsicCooldownTime && _intrinsicList.Count < _maxNumberOfIntrinsic)
        {
            var intrinsicProjectile = Instantiate(_intrinsic, transform.position + new Vector3(Random.Range(-4f,4f), Random.Range(0.6f, 1f), Random.Range(-4f, 4f)), transform.rotation);
            _intrinsicList.Add(intrinsicProjectile);
            _intrinsicSkillStartTime = Time.time;
        }
    }

    public void DefaultRangeSkillEx()
    {
        StartCoroutine(DefaultRangeSkill());
    }

    public void FirstSkillEx()
    {
        StartCoroutine(FirstSkill());
    }

    public void SecondSkillEx()
    {
        StartCoroutine(SecondSkill());
    }

    public void ThirdSkillEx()
    {
        StartCoroutine(ThirdSkill());
    }

    // Skill 1
    IEnumerator FirstSkill()
    {
        if (Time.time - _firstSkillStartTime > _firstSkillCooldownTime)
        {
            Vector3 temp = (_targetTransform.position - transform.position).normalized;
            transform.forward = new Vector3(temp.x, 0f, temp.z);
            _boss1Animator.CrossFade("FirstSkill", 0f);
            _firstSkillStartTime = Time.time;
            yield return new WaitForSeconds(0.5f);
            _firstSkillVFX.transform.position = transform.position;
            _firstSkillVFX.SetActive(true);
            yield return new WaitForSeconds(_firstSkillDuration);
            _firstSkillVFX.SetActive(false);
        }

    }

    // Skill 2
    IEnumerator SecondSkill()
    {
        if (Time.time - _secondSkillStartTime > _secondSkillCooldownTime)
        {
            Vector3 temp = (_targetTransform.position - transform.position).normalized;
            transform.forward = new Vector3(temp.x, 0f, temp.z);
            _boss1Animator.CrossFade("SecondSkill", 0f);
            yield return new WaitForSeconds(0.7f);
            _secondSkillVFX.SetActive(true);
            yield return new WaitForSeconds(1f);
            _secondSkillVFX.SetActive(false);
            _secondSkillStartTime = Time.time;
        }
    }

    // Skill Ultimate, active intrinsic
    IEnumerator ThirdSkill()
    {
        Vector3 temp = (_targetTransform.position - transform.position).normalized;
        transform.forward = new Vector3(temp.x, 0f, temp.z);

        _boss1Animator.CrossFade("ThirdSkill", 0f);
        yield return new WaitForSeconds(1.2f);
        foreach (GameObject gameObject in _intrinsicList)
        {
            gameObject.GetComponent<EnemyDamageObject>().Damage = _intrinsicDamage;
            gameObject.GetComponent<EnemyDamageObject>().TurnOnGetHitAnimation = true;
            gameObject.GetComponent<Boss1Intrinsic>().ActiveIntrinsicSkill();
        }
        _intrinsicList.Clear();
        _intrinsicSkillStartTime = Time.time;
    }

    private void DefaultMeleeSkill()
    {
        _boss1Animator.CrossFade("DefaultMeleeSkill", 0f);
    }

    IEnumerator DefaultRangeSkill()
    {
        if (Time.time - _defaultRangeSkillStartTime > _defaultRangeSkillCooldownTime)
        {
            _defaultRangeSkillStartTime = Time.time;
            Vector3 temp = (_targetTransform.position - transform.position).normalized;
            transform.forward = new Vector3(temp.x, 0f, temp.z);
            _boss1Animator.CrossFade("DefaultRangeSkill", 0f);
            yield return new WaitForSeconds(0.4f);

            var projectile = Instantiate(_defaultRangeSkillProjectile, _defaultRangeSkillSpawnPoint.position, _defaultRangeSkillSpawnPoint.rotation);

            Vector3 direction = (_targetTransform.position - _defaultRangeSkillSpawnPoint.position).normalized;
            projectile.GetComponent<Rigidbody>().velocity = direction * _defaultRangeSkillSpeed;
        }
    }
}
