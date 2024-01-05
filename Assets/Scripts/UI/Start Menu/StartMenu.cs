using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private SaveLoadSystem _saveLoadSystem;
    [SerializeField] private GameObject _newGameMenu;
    [SerializeField] private GameObject _continueGameMenu;
    [SerializeField] private GameObject _selectDifficultyMenu;
    [SerializeField] private int _indexOfMainScene = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGameOnClick()
    {
        _newGameMenu.SetActive(false);
        _continueGameMenu.SetActive(false);
        _selectDifficultyMenu.SetActive(true);
    }

    public void GoBackNewGameOnClick()
    {
        _newGameMenu.SetActive(true);
        _continueGameMenu.SetActive(false);
        _selectDifficultyMenu.SetActive(false);
    }

    public void LoadBalanceExperienceScene()
    {
        _saveLoadSystem.SaveData(true);
        RuntimeQuestData.InitializeBalanceExperienceQuestsDefaultValue();
        QuestDataSaveLoadSystem.SaveQuestData();
        SceneManager.LoadScene(_indexOfMainScene);
    }

    public void LoadChallengeScene()
    {
        _saveLoadSystem.SaveData(true);
        RuntimeQuestData.InitializeChallengeQuestsDefaultValue();
        QuestDataSaveLoadSystem.SaveQuestData();
        SceneManager.LoadScene(_indexOfMainScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
