using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float enemySpawnDuration;
    [SerializeField] private float enemyDieDuration;
    [SerializeField] private PlayerHealth playerHealth;
    private GameObject clone = null;
    private Vector2 screenHalfSizeWorldUnits;

    private void Start()
    {
        screenHalfSizeWorldUnits =
            new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
        StartCoroutine(SpawnEnemy());
    }


    public IEnumerator SpawnEnemy()
    {
        while (playerHealth.AliveCheck())
        {
            clone = Instantiate(enemyPrefab,
                    new Vector3(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x),
                        (transform.position.y)), Quaternion.identity);
            KillEnemy();
            yield return new WaitForSeconds(enemySpawnDuration);
        }
    }

    public IEnumerator KillEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemyDieDuration);
            Destroy(clone);
        }
    }
}
