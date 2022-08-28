using System.Collections;
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
        StartCoroutine(SpawnTripleBullet());
    }

    public IEnumerator SpawnTripleBullet()
    {
        while (isShootAvailable)
        {
            int x = -30;
            bullets = new GameObject[3];

            for (int i = 0; i < bullets.Length; i++)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, x)));
                x += 30;
            }
            yield return new WaitForSeconds(bulletSpawnDuration);
        }
    }
}
