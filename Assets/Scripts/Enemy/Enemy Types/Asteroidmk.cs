using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidmk : MonoBehaviour
{
    [SerializeField] private int asteriodContactDamage;
    [SerializeField]  private float asteroidDestroyTime;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject target = collision.gameObject;

        if (target != null)
        {
            if (gameObject.TryGetComponent(out PlayerHealth player) || gameObject.TryGetComponent(out PlayerGun _))
            {

                player.DecraseHealth(asteriodContactDamage);

                DestroyAsteroid();
            }
        }
    }

    private void DestroyAsteroid()
    {
        Destroy(this, asteroidDestroyTime);
    }
}
