using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance { get; private set; }

    [SerializeField]int score = 0;
    static int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more that one ScoreKeeper! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int points)
    {
        score += points;
    }


}
