using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    protected override void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;
        Vector2 contactPoint = other.GetContact(0).point;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out EnemyHealth enemy) || gameObject.TryGetComponent(out EnemySpawner _))
            {
                enemy.DecraseHealth(bulletDamage);

                DestroyBullet(contactPoint);
                DestroyBullet();
            }
            else if (gameObject.TryGetComponent(out Asteroidmk asteroid))
            {
                asteroid.DestroyPlayerBullet(this.gameObject, contactPoint);
                DestroyBullet();
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}