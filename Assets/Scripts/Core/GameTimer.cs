using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public static GameTimer Instance { get; private set; }

    [Tooltip("Game time in seconds")]
    [SerializeField]int maxGameTime=120;
    float gameTimeRemind;
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more that one GameTimer! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
        gameTimeRemind = (float)maxGameTime;
        
    }

    void Update()
    {
       gameTimeRemind -= Time.deltaTime;
    if (gameTimeRemind<=0)
        {
            SceneMenagement.Instance.LoadNextScene();
        }
    }

    public int GetTimeRemined()
    {
        return (int)gameTimeRemind;
    }
} 
