using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStartScene : MonoBehaviour
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
