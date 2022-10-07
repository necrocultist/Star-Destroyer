using System;
using UnityEngine;

public class PlayerHealth : Character
{
    [SerializeField] private int contactDamage;

    [SerializeField] private GameObject[] healths;
    private int index = 0;

    public event Action OnHealthDecrease;
    public event Action OnPlayerDeath;

    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;
        
        if (!AliveCheck())
        {
            gameObject.SetActive(false);

            OnPlayerDeath?.Invoke();
        }

        else
        {
            Destroy(healths[index]);
            index++;
        }

        OnHealthDecrease?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out EnemyHealth enemy) || gameObject.TryGetComponent(out EnemySpawner _))
            {
                DecraseHealth(contactDamage);

                Destroy(enemy);
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }

    public int GetContactDamage()
    {
        return contactDamage;
    }

    public void CreateBulletDestroyEffect(Vector2 contactPoint)
    {
        GameObject destroyEffect = Instantiate(bulletDestroyEffect, contactPoint, Quaternion.identity);
        Destroy(destroyEffect, bulletDestroyTime);
    }
}