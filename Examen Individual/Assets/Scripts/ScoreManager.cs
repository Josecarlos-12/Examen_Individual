using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int score;

    public delegate void ScoreChangedDelegate(int newScore);
    public event ScoreChangedDelegate OnScoreChanged;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore(int incrementAmount)
    {
        score += incrementAmount;
        OnScoreChanged?.Invoke(score);
    }

    public void IncrementScoreByOne()
    {
        IncrementScore(1);
    }

    public void IncrementScoreByTwo()
    {
        IncrementScore(2);
    }

    public void IncrementScoreByThree()
    {
        IncrementScore(3);
    }

    public int GetScore()
    {
        return score;
    }
}
