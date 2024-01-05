using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryUI : MonoBehaviour
{
    [SerializeField] GameObject _victory;

    // Update is called once per frame
    void Update()
    {
        if (RuntimeQuestData.GetCurrentQuest().Id == "complete")
        {
            StartCoroutine(Victory());
        } 
    }

    IEnumerator Victory()
    {
        yield return new WaitForSeconds(4f);
        _victory.SetActive(true);

        RuntimeEquipmentData.InitializeData = false;
        RuntimeSkillData.InitializeData = false;
        RuntimeQuestData.InitializeData = false;
        RuntimePlayerData.InitializeData = false;

        RuntimeSkillData.SkillDictionary = new Dictionary<string, Skill>();
        //RuntimeQuestData.QuestData = null;
        //_playerData = null;
        //RuntimeEquipmentData.EquipmentData = null;
        // only skill data need to initialize

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadStartSceneOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
