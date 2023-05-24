using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : ScoreObserver
{
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        ScoreManager.instance.OnScoreChanged += UpdateScore;
    }

    public override void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
