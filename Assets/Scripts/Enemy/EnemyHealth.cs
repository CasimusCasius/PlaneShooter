using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int pointsForDestroy = 100;
    ScoreKeeper scoreKeeper;
    private void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name);
        scoreKeeper.AddScore(pointsForDestroy);
        Die();
    }

    private void Die()
    {
        MoveToPool();
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MoveToPool();
    }

    private void MoveToPool()
    {
        transform.position = FindObjectOfType<EnemyPool>().transform.position;
        gameObject.SetActive(false);
    }
}
