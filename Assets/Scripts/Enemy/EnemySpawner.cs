using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float enemySpawnDuration;
    [SerializeField] private Health playerHealth;
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
            GameObject clone = (GameObject)Instantiate(enemyPrefab,
                    new Vector3(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x),
                        (transform.position.y)), Quaternion.identity);

            yield return new WaitForSeconds(enemySpawnDuration);
        }
    }
}
