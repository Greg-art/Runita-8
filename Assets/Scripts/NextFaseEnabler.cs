using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFaseEnabler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GamePauser.Instance.PauseGame(true);
        Debug.Log("Leva");
    }
}
