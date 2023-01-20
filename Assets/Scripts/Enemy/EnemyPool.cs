
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool Instance { get; private set; }

    [SerializeField] EnemyMover[] enemies;
    [SerializeField] FlightLine[] flightLines;
    [SerializeField] float spawnTimeDelay = 1f;
    [SerializeField] int minNumberOfSpawnedEnemies = 2;
    [SerializeField] int maxNumberOfSpawnedEnemies = 5;
    float timeFromPreviousSpawn;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more that one EnemyPool! " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        timeFromPreviousSpawn = spawnTimeDelay;
    }

    private void Start()
    {
        SpawnEnemies();
    }
    private void Update()
    {
        timeFromPreviousSpawn -= Time.deltaTime;
        if (timeFromPreviousSpawn <=0)
        {
            SpawnEnemies();
            timeFromPreviousSpawn = spawnTimeDelay;
        }
    }

    private void SpawnEnemies()
    {
        ResetFlightlines();

        int numberOfSpawnedEnemies = UnityEngine.Random.Range(minNumberOfSpawnedEnemies, maxNumberOfSpawnedEnemies);

        for (int i = numberOfSpawnedEnemies; i >= 0; i--)
        {
            Debug.Log(i);
            foreach (var enemy in enemies)
            {
                if (!enemy.gameObject.activeSelf)
                {
                    Debug.Log("Spawning");
                    enemy.gameObject.SetActive(true);
                    PlaceEnemy(enemy);

                    break;
                }
            }
        }                   
    }

    private void ResetFlightlines()
    {
        foreach(var flightLine in flightLines)
        {
            flightLine.SetFlightlineBusy(false);
        }
    }

    private void PlaceEnemy(EnemyMover enemy)
    {

        bool isPlaced = false;
        while (!isPlaced)
        {
            int flightLineNumber = UnityEngine.Random.Range(0, flightLines.Length);
           
            if (!flightLines[flightLineNumber].GetFlightlineBusy())
            {
                enemy.transform.position = flightLines[flightLineNumber].transform.position;
                flightLines[flightLineNumber].SetFlightlineBusy(true);
                isPlaced = true;
            }
        }
    }
}
