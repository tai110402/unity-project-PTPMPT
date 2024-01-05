using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
    [SerializeField] private GameObject _playerGameObject;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SkillDataSaveLoadSystem.SaveSkillData();

            RuntimePlayerData.PlayerData.Position = _playerGameObject.transform.position;
            PlayerDataSaveLoadSystem.SavePlayerData();

            EquipmentDataSaveLoadSystem.SaveEquipmentData();
            QuestDataSaveLoadSystem.SaveQuestData();
            Debug.Log(RuntimeQuestData.GetQuestData());
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SkillDataSaveLoadSystem.LoadSkillData();

            PlayerDataSaveLoadSystem.LoadPlayerData();
            CharacterController characterController = _playerGameObject.GetComponent<CharacterController>();
            characterController.enabled = false;
            _playerGameObject.transform.position = RuntimePlayerData.PlayerData.Position;
            characterController.enabled = true;

            EquipmentDataSaveLoadSystem.LoadEquipmentData();
            QuestDataSaveLoadSystem.LoadQuestData();
        }
    }

    public void SaveData(bool resetPlayerPosition)
    {
        SkillDataSaveLoadSystem.SaveSkillData();

        if (resetPlayerPosition)
        {
            RuntimePlayerData.PlayerData.Position = new Vector3(0f, 0f, 0f);
        } else
        {
            RuntimePlayerData.PlayerData.Position = _playerGameObject.transform.position;
        }

        PlayerDataSaveLoadSystem.SavePlayerData();

        EquipmentDataSaveLoadSystem.SaveEquipmentData();
        QuestDataSaveLoadSystem.SaveQuestData();
    }

    public void LoadData()
    {
        SkillDataSaveLoadSystem.LoadSkillData();

        PlayerDataSaveLoadSystem.LoadPlayerData();
        CharacterController characterController = _playerGameObject.GetComponent<CharacterController>();
        characterController.enabled = false;
        _playerGameObject.transform.position = RuntimePlayerData.PlayerData.Position;
        characterController.enabled = true;

        EquipmentDataSaveLoadSystem.LoadEquipmentData();
        QuestDataSaveLoadSystem.LoadQuestData();
    }
}
