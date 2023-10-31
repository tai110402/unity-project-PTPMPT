using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningNewSkill : MonoBehaviour
{
    [SerializeField] private string _newSkillName = "FirstSwordSkill002";
    [SerializeField] private bool _isUsing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Dictionary<string, Skill> dict = RuntimeSkillData.SkillDictionary;
            dict[_newSkillName].IsUnlocked = true;
            dict[_newSkillName].IsUsing = _isUsing;
            Debug.Log("Learning Compeletely" + ", IsUsing: " + _isUsing + ", Skill Name: " + _newSkillName);
        }
    }
}
