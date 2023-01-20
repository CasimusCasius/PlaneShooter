using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenagement : MonoBehaviour
{

    public static SceneMenagement Instance;
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

    public void LoadNextScene()
    {
        int numberOfScenes = SceneManager.sceneCountInBuildSettings;


        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (numberOfScenes - 1 < nextSceneIndex )
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene( nextSceneIndex );
    }
}
