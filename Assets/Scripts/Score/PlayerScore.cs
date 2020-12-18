using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour, IHaveScore
{
    //TODO refatorar isso aqui inteiro para separar responsabilidades
    [SerializeField] private TextMeshProUGUI _scoreDisplay = default;
    [SerializeField] private TextMeshProUGUI _highScoreDisplay = default;

    public int _currentScore;
    private int _highScore;
    [SerializeField] private Image RoxoPulse = default;
    [SerializeField] private Image IconePulse = default;
    
    private void Start(){
        RoxoPulse.CrossFadeAlpha(0, 0, true);
        IconePulse.CrossFadeAlpha(0, 0, true);
    }
    void Awake()
    {
        _currentScore = 0;
        _highScore = PlayerPrefs.GetInt("highScore", 0);
        _currentScore = PlayerPrefs.GetInt("points", 0);
        _scoreDisplay.SetText($"{_currentScore}");

        _highScoreDisplay.SetText($"Recorde: {_highScore}");

    }

    public void HandleScore(int scoreAmount)
    {
        _currentScore = PlayerPrefs.GetInt("points");
        _currentScore++;
        PlayerPrefs.SetInt("points", _currentScore);

        RoxoPulse.CrossFadeAlpha(1, 0, true);
        RoxoPulse.CrossFadeAlpha(0, 0.7f, true);
        IconePulse.CrossFadeAlpha(1, 0, true);
        IconePulse.CrossFadeAlpha(0, 2.0f, true);
        
        

        if (_currentScore > _highScore)
        {
            _highScore = _currentScore;
            PlayerPrefs.SetInt("highScore", _highScore);
        }

        _scoreDisplay.SetText($"{_currentScore}");
        _highScoreDisplay.SetText($"Recorde: {_highScore}");
    }
}