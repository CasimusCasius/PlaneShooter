using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreField;
    [SerializeField] TextMeshProUGUI highscoreField;
    ScoreKeeper scoreKeeper;
    private void Awake()
    {
        scoreKeeper = ScoreKeeper.Instance;
    }

    private void OnEnable()
 
    {
        scoreKeeper.onScoreChange += ScoreUpdate;
    
    }
    private void OnDisable()
    {
        scoreKeeper.onScoreChange -= ScoreUpdate;
    }
    void ScoreUpdate()
    {
        scoreField.text = string.Format("Score: {0}", scoreKeeper.GetScore()) ;
        highscoreField.text = string.Format("Highscore: {0}", scoreKeeper.GetHighScore());
    }

   
  
       
    
}
