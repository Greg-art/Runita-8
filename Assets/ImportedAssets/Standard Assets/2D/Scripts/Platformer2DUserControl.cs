using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool _isJumping;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!_isJumping)
            {
                _isJumping = Input.GetMouseButtonDown(0);

                //TODO tirar a lógica de respawnar daqui
                if (GamePauser.Instance.GetGameIsPaused())
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        GamePauser.Instance.PauseGame(false);
                        Scene currentScene = SceneManager.GetActiveScene();

                        if (currentScene.name == "Extra")
                        {
                            SceneManager.LoadScene("MainLevel");
                        }
                        else
                        {
                            SceneManager.LoadScene(currentScene.name);
                        }
                    }
                }
            }
        }


        private void FixedUpdate()
        {

            m_Character.Move(1, false, _isJumping);
            _isJumping = false;
        }
    }
}
