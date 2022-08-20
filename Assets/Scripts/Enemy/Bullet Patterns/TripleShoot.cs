using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class TripleShoot : MonoBehaviour
{
    [SerializeField] private GameObject[] bullets;
    [SerializeField] private GameObject bulletPrefab;
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
            int x = -15;
            bullets = new GameObject[3];

            for (int i = 0; i < bullets.Length; i++)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, x)));
                x += 15;
            }
            yield return new WaitForSeconds(bulletSpawnDuration);
        }
    }
}
