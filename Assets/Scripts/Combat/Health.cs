using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int currentHealth;
    [SerializeField] protected int contactDamage;

    [SerializeField] protected GameObject destroyEffect;
    [SerializeField] protected float destroyTime;
    
    [SerializeField] protected GameObject bullet;

    protected void ResetHealth()
    {
        currentHealth = maxHealth;
    }

    public void IncreaseHealth(int refill)
    {
        currentHealth += refill;
    }

    public bool AliveCheck()
    {
        return currentHealth > 0;
    }

    public void DestroyBullet(GameObject bullet, Vector2 contact)
    {
        Destroy(bullet);
        GameObject destroyedObject = Instantiate(destroyEffect, contact, Quaternion.identity);
        Destroy(destroyedObject, destroyTime);
    }
}

