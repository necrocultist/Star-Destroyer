using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Transform[] spawnPoints;
    private int randomSpawnPoint;
    [SerializeField] private float asteroidSpawnTime;
    [SerializeField] private GameObject asteroid;
    void Start()
    {
        StartCoroutine(SpawnAsteroid());
    }

    public IEnumerator SpawnAsteroid()
    {
        yield return new WaitForSeconds(asteroidSpawnTime);
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        if (spawnPoints[randomSpawnPoint].position.x > 0)
        {
            Instantiate(asteroid, spawnPoints[randomSpawnPoint].position, Quaternion.Euler(new Vector3(0, 0, 135)));
        }
        else if(spawnPoints[randomSpawnPoint].position.x < 0)
        {
            Instantiate(asteroid, spawnPoints[randomSpawnPoint].position, Quaternion.Euler(new Vector3(0, 0, -135)));
        }
        
}

}
