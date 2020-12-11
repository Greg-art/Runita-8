using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour, IHaveScore
{
    //TODO refatorar isso aqui inteiro para separar responsabilidades
    [SerializeField] private TextMeshProUGUI _scoreDisplay = default;
    [SerializeField] private TextMeshProUGUI _highScoreDisplay = default;

    private int _currentScore;
    private int _highScore;

    void Awake()
    {
        _currentScore = 0;
        _highScore = PlayerPrefs.GetInt("highScore", 0);

        _highScoreDisplay.SetText($"Recorde: {_highScore}");
    }

    public void HandleScore(int scoreAmount)
    {
        _currentScore++;

        if (_currentScore > _highScore)
        {
            _highScore = _currentScore;
            PlayerPrefs.SetInt("highScore", _highScore);
        }

        _scoreDisplay.SetText($"Pontuação: {_currentScore}");
        _highScoreDisplay.SetText($"Recorde: {_highScore}");
    }
}