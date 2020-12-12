using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauser : MonoBehaviour
{
    public static GamePauser Instance;
    private bool _gameIsPaused = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PauseGame(bool isPaused)
    {
        _gameIsPaused = isPaused;
        if (_gameIsPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public bool GetGameIsPaused()
    {
        return _gameIsPaused;
    }
}
