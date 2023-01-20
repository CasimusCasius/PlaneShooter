using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI livesText;
     Lives lives;
    private void Awake()
    {
        lives = FindObjectOfType<Lives>();
    }

    private void OnEnable()

    {
        lives.onLivesChanged += LivesUpdate;

    }
    private void OnDisable()
    {
        lives.onLivesChanged -= LivesUpdate;
    }
    void LivesUpdate()
    {
        livesText.text = string.Format("Lives: {0}", lives.GetLives());
        
    }
}
