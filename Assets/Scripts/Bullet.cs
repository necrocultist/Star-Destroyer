using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected int bulletDamage;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected GameObject destroyEffect;
    [SerializeField] protected float destroyTime;
    
    void FixedUpdate()
    {
        MoveBullet();
    }

    protected void MoveBullet()
    {
        transform.Translate(new Vector2(0, bulletSpeed * Time.fixedDeltaTime));
    }

    protected virtual void OnCollisionEnter2D(Collision2D other) {}
    public void DestroyBullet(Vector2 contact)
    {
        Destroy(gameObject);
        GameObject destroyedObject = Instantiate(destroyEffect, contact, Quaternion.identity);
        Destroy(destroyedObject, destroyTime);
    }
}

