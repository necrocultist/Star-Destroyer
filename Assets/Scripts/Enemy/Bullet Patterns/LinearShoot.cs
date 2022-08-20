using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class LinearShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpawnDuration;
    private bool isShootAvailable;

    private void OnEnable()
    {
        isShootAvailable = true;
        StartCoroutine(SpawnBullet());
    }

    public IEnumerator SpawnBullet()
    {
        while (isShootAvailable)
        {
            Instantiate(bullet, transform.position, quaternion.identity);

            yield return new WaitForSeconds(bulletSpawnDuration);
        }
    }
}