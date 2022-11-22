using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    [HeaderAttribute("Scenes names")]
    public string _gameSceneName = "DevGame";

    private static ScenesManager _instance;
    public static ScenesManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Scenes Manager is Null");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(_gameSceneName);
    }
}
