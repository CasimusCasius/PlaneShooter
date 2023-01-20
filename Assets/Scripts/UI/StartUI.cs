using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] TextMeshProUGUI lastScoreText;


    void Start()
    {
        highScoreText.text = string.Format("Current HighScore: {0}", ScoreKeeper.Instance.GetHighScore());
        lastScoreText.text = string.Format("Last Game Score: {0}", ScoreKeeper.Instance.GetScore());

    }


    private void Update()
    {
        if(Input.anyKey) {
            SceneMenagement.Instance.LoadNextScene();
        }
    }
}
