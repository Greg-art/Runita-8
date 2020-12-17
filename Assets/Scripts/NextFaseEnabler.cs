using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;

public class NextFaseEnabler : MonoBehaviour
{
    [SerializeField] private string _sceneToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlatformerCharacter2D>() != null)
        {
            SceneManager.LoadScene(_sceneToLoad);
        }
    }
}
