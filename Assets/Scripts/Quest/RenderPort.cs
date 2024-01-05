using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderPort : MonoBehaviour
{
    [SerializeField] private string[] _questIdArray;
    [SerializeField] private GameObject _port;

    // Update is called once per frame
    void Update()
    {
        Quest quest = RuntimeQuestData.GetCurrentQuest();
        foreach(string questId in _questIdArray)
        if (quest.Id == questId)
        {
            _port.SetActive(true);
        }
    }
}
