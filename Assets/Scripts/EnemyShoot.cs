using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    private bool shoot;
    public GameObject enemy;
    public float bulletSpawnDuration;
    private void OnEnable()
    {
        shoot = true;
        StartCoroutine(SpawnBullet());
    }

    public IEnumerator SpawnBullet()
    {
        while (shoot)
        {
            Instantiate(bullet, enemy.transform.position, quaternion.identity);
            
            yield return new WaitForSeconds(bulletSpawnDuration);
        }
    }
}
