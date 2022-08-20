using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularShoot : MonoBehaviour
{
    private GameObject[] bullets;
    public GameObject bulletPrefab;
    private int x = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnCircular());
    }

    public IEnumerator SpawnCircular()
    {
        bullets = new GameObject[8];

        while (true)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(new Vector3(0, 0, x)));
                x += 45;
            }
        }
    }
}
