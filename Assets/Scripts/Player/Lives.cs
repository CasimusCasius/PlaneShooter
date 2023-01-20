using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public event Action onLivesChanged;
    [SerializeField] int lives = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }
    public int GetLives() => lives;

    private void Die()
    {
        lives--;
        onLivesChanged?.Invoke();

        if (lives<=0)
        {
            {
                SceneMenagement.Instance.LoadNextScene();
            }
        }
    }
}
