using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private Transform _arrowTransform;
    [SerializeField] private GameObject _shortArrow;
    [SerializeField] private GameObject _longArrow;
    [SerializeField] private float _distance;

    private static bool _setArrow = true;
    public static bool SetArrow { set { _setArrow = value; } }

    // Update is called once per frame
    void Update()
    {
        if (_setArrow)
        {
            GameObject player = GameObject.FindWithTag("Player");
            Quest currentQuest = RuntimeQuestData.GetCurrentQuest();
            float currentDistance = Vector3.Magnitude(player.transform.position - currentQuest.Position);

            if (currentDistance < _distance)
            {
                _longArrow.SetActive(false);
                _shortArrow.SetActive(true);
            }
            else
            {
                _longArrow.SetActive(true);
                _shortArrow.SetActive(false);
            }
            
        } else
        {
            _longArrow.SetActive(false);
            _shortArrow.SetActive(false);
        }
        _arrowTransform.position = RuntimeQuestData.GetCurrentQuest().Position;
    }
}
