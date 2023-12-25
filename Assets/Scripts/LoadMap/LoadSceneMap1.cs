using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneMap1 : MonoBehaviour
{
    [SerializeField] private SaveLoadSystem _saveLoadSystem;
    [SerializeField] private int _indexScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            _saveLoadSystem.SaveData(true);
            SceneManager.LoadScene(_indexScene );
        }
    }
}
