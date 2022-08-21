using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidmk : MonoBehaviour
{
    [SerializeField] private int asteriodContactDamage;
    [SerializeField] private float asteroidDestroyTime;
    [SerializeField] private GameObject bulletDestroyEffect;
    [SerializeField] private float destroyTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject target = collision.gameObject;

        if (target != null)
        {
            if (target.TryGetComponent(out PlayerHealth player) || target.TryGetComponent(out PlayerGun _))
            {
                Debug.Log("a");

                player.DecraseHealth(asteriodContactDamage);

                DestroyObject();
            }
        }
    }
    public void DestroyObject()
    {
        Destroy(this, asteroidDestroyTime);
    }

    public void DestroyPlayerBullet(GameObject playerBullet, Vector2 contact)
    {
        Destroy(playerBullet);
        GameObject destroyedObject = Instantiate(bulletDestroyEffect, contact, Quaternion.identity);
        Destroy(destroyedObject, destroyTime);
    }
}