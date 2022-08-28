using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float asteroidSpawnTime;
    [SerializeField] private GameObject asteroid;
    private int randomSpawnPoint;

    void Start()
    {
        StartCoroutine(SpawnAsteroid());
    }

    public IEnumerator SpawnAsteroid()
    {
        while (true)
        {
            yield return new WaitForSeconds(asteroidSpawnTime);
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        
            if (spawnPoints[randomSpawnPoint].position.x > 0)
            {
                Instantiate(asteroid, spawnPoints[randomSpawnPoint].position, Quaternion.Euler(new Vector3(0, 0, 135)));
            }
            else if (spawnPoints[randomSpawnPoint].position.x < 0)
            {
                Instantiate(asteroid, spawnPoints[randomSpawnPoint].position, Quaternion.Euler(new Vector3(0, 0, -135)));
            }
        }
    }
}
