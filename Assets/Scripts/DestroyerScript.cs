using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    //TODO tirar toda essa lógica do gameOverCanvas e morte do jogador daqui

    [SerializeField] private Canvas _gameOverCanvas;

    void Awake()
    {
        _gameOverCanvas.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            if (other.gameObject.transform.parent)
                Destroy(other.gameObject.transform.parent.gameObject);
            else
                Destroy(other.gameObject);
        }
        else
        {
            _gameOverCanvas.gameObject.SetActive(true);
            GamePauser.Instance.PauseGame(true);
        }
    }
}
