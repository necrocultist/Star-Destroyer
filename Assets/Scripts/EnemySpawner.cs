using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnPoint;
    public float enemySpawnDuration;
    public Health playerHealth;
    private Vector2 screenHalfSizeWorldUnits;

    private void Start()
    {
        screenHalfSizeWorldUnits =
            new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
        StartCoroutine(SpawnEnemy());
    }


    public IEnumerator SpawnEnemy()
    {
        while (playerHealth.isAlive)
        {
            Instantiate(enemyPrefab,
                    new Vector3(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x),
                        (spawnPoint.transform.position.y)), Quaternion.identity);

            yield return new WaitForSeconds(enemySpawnDuration);
        }
    }
}
