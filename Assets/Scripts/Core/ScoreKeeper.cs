using Saving;
using SceneManagment;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour,ISaveable
{
    public event Action onScoreChange;
    public static ScoreKeeper Instance;

    [SerializeField]static int score = 0;
    static int highScore;
    SavingWrapper savingWrapper;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more that one ScoreKeeper! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
       
       
    }
    private void Start()
    {
        savingWrapper = FindObjectOfType<SavingWrapper>();
        onScoreChange?.Invoke();
    }

    public void AddScore(int points)
    {
        score += points;
        CheckHighScore();
        onScoreChange?.Invoke();

    }

    private void CheckHighScore()
    {
        if (score >= highScore)
        {
            highScore = score;
            savingWrapper.Save();
        }
    }

    public int GetScore() { return score; }
    public int GetHighScore() { return highScore; }

    public void ResetScore()
    {
        score = 0;
    }

    public object CaptureState()
    {
        return highScore;
    }

    public void RestoreState(object state)
    {
        highScore = (int)state;
    }
}
