using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float playerBulletSpeed;
    [SerializeField] private int playerBulletDamage;

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
        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out Health enemy))
            {
                enemy.DecraseHealth(playerBulletDamage);
                if (enemy.currentHealth <= 0)
                {
                    enemy.isAlive = false;
                }
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
}
