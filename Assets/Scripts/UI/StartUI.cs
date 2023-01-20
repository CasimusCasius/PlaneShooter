using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;

    void Start()
    {
        highScoreText.text = string.Format("Current HighScore: {0}", ScoreKeeper.Instance.GetHighScore());
    }


    private void Update()
    {
        if(Input.anyKey) {
            SceneMenagement.Instance.LoadNextScene();
        }
    }
}
