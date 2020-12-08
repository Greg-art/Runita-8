using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    void OnClick()
    {
        Application.Quit(0);
    }
}
