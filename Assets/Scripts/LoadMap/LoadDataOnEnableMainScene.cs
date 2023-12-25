using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataOnEnableMainScene : MonoBehaviour
{
    [SerializeField] private SaveLoadSystem _saveLoadSytem;

    // Start is called before the first frame update
    void Start()
    {
        _saveLoadSytem.LoadData();
    }
}
