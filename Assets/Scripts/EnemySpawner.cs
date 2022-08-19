using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnPoint;
    public GameObject[] enemies;
    public float enemySpawnDuration;
    public Health playerHealth;
    bool first = true;

    private void Update()
    {
        StartCoroutine(SpawnEnemy());
        first = false;//to prevent Update from running Spawn function multiple times

    }

    public IEnumerator SpawnEnemy()
    {
        enemies = new GameObject[1];

        while (playerHealth.isAlive)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                GameObject clone = (GameObject)Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(enemySpawnDuration);
        }
    }
}
