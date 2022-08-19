using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Health healthscr;
    [SerializeField] private float damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            healthscr.TakeDamage(damage);
            if (healthscr.currentHealth <= 0)
            {
                healthscr.isAlive = false;
                
            }
        }
    }

    void Update()
    {
        
    }
}
