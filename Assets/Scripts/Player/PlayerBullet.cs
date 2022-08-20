using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float playerBulletSpeed;
    [SerializeField] private int playerBulletDamage;
    [SerializeField] private GameObject bulletDestroyEffect;
    [SerializeField] private float destroyTime;

    void FixedUpdate()
    {
        PlayerBulletMove();
    }

    private void PlayerBulletMove()
    {
        transform.Translate(new Vector2(0, playerBulletSpeed * Time.fixedDeltaTime));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;
        Vector2 contactPoint = other.GetContact(0).point;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out EnemyHealth enemy))
            {
                enemy.DecraseHealth(playerBulletDamage);
                if (enemy.currentHealth <= 0)
                {
                    enemy.isAlive = false;
                }

                DestroyPlayerBullet(contactPoint);
                DestroyBullet();
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }

    private void DestroyPlayerBullet(Vector2 enemy)
    {
        gameObject.SetActive(false);
        GameObject destroyedObject =  Instantiate(bulletDestroyEffect, enemy, Quaternion.identity);
        Destroy(destroyedObject, destroyTime);
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
