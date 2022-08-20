using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private GameObject[] bullets;
    void Start()
    {
        StartCoroutine(SpawnCircular());
    }

    public IEnumerator SpawnCircular()
    {
        while (true)
        {
            bullets = new GameObject[8];

            for (int i = 0, x = 0; i < bullets.Length; i++)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, x)));
                x += 45;
            }
            yield return new WaitForSeconds(3);
        }
    }
}
