using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularShoot : MonoBehaviour
{
    private GameObject[] bullets;
    public GameObject bulletPrefab;
   // private int x = 0;
    void Start()
    {
        StartCoroutine(SpawnCircular());
    }

    public IEnumerator SpawnCircular()
    {
        while (true)
        {
            bullets = new GameObject[8];

            for (int i = 0; i < bullets.Length; i++)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(3);
        }
    }
}
