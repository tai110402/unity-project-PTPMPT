using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    [SerializeField] private Text _content;
    [SerializeField] private Text _currentState01;
    [SerializeField] private Text _currentState02;

    // Update is called once per frame
    void Update()
    {
        Quest currentQuest = RuntimeQuestData.GetCurrentQuest();
        GameObject player = GameObject.FindWithTag("Player");
        int distance = (int)Vector3.Magnitude(player.transform.position - currentQuest.Position);
        _content.text = currentQuest.Content;
        _currentState01.text = "Distance: " + distance.ToString() + "m";

        if (currentQuest.Type == "moving")
        {
            _currentState02.text = "< " + distance.ToString() + "m >";
        } else if (currentQuest.Type == "attack")
        {
            _currentState02.text = "< " + currentQuest.Progress + "/" + currentQuest.Condition + " >";
        }

        Debug.Log(currentQuest.Content);
    }
}
