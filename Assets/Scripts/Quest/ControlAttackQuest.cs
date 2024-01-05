using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAttackQuest : MonoBehaviour
{
    [SerializeField] private string _questId = "002";
    [SerializeField] private GameObject[] _enemies;
    [SerializeField] private float _minDistanceRenderArrow = 8;
    [SerializeField] private int[] _enemiesInWaveArray;
    [SerializeField] private float[] _timeAppearArray;

    private bool _isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Quest currentQuest = RuntimeQuestData.GetCurrentQuest();

        if (currentQuest.Id == _questId && _isActive == false)
        {
            _isActive = true;
            StartCoroutine(SpawnEnemies(_enemiesInWaveArray, _timeAppearArray));
        }

        float distance = Vector3.Magnitude(player.transform.position - currentQuest.Position);
        
        if (currentQuest.Type == "attack")
        {
            if (distance > _minDistanceRenderArrow)
            {
                Arrow.SetArrow = true;
            }
            else
            {
                Arrow.SetArrow = false;
            }
        }
    }

    IEnumerator SpawnEnemies(int[] enemiesInWaveArray, float[] timeAppearArray)
    {
        int index = 0;
        for (int i = 0; i < enemiesInWaveArray.Length; i++)
        {
            yield return new WaitForSeconds(timeAppearArray[i]);
            for (int z = 0; z < enemiesInWaveArray[i]; z++)
            {
                _enemies[index].SetActive(true);
                index += 1;
            }
            
        }
    }
}
