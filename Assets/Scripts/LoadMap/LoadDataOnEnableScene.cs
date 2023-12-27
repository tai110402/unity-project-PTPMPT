using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataOnEnableScene : MonoBehaviour
{
    [SerializeField] private SaveLoadSystem _saveLoadSystem;
    private void OnEnable()
    {
        _saveLoadSystem.LoadData();
    }
}
