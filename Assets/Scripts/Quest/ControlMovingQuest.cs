using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovingQuest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Quest currentQuest = RuntimeQuestData.GetCurrentQuest();

        if (currentQuest.Type == "moving")
        {
            float distance = Vector3.Magnitude(player.transform.position - currentQuest.Position);
            if (distance < 1)
            {
                Arrow.SetArrow = false;
                RuntimeQuestData.CompleteQuest();
            } else
            {
                Arrow.SetArrow = true;
            }
        }
    }
}
