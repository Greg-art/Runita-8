using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //TODO refatorar isso aqui inteiro para separar responsabilidades
    [SerializeField] private TextMeshProUGUI _scoreDisplay;
    [SerializeField] private TextMeshProUGUI _highScoreDisplay;

    private int _currentScore;
    private int _highScore;

    void Awake()
    {
        _currentScore = 0;
        _highScore = PlayerPrefs.GetInt("highScore", 0);

        _highScoreDisplay.SetText($"Recorde: {_highScore}");

        InvokeRepeating("IncreaseScore", 0.3f, 0.3f);
    }

    void IncreaseScore()
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