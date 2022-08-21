using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject target = collision.gameObject;
        DestroyAsteroid(target); 
    }
    private void DestroyAsteroid(GameObject obj)
    {
        Destroy(obj);
    }
}
