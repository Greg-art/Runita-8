using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelButton : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad = default;

    public void OnClick()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }
}
