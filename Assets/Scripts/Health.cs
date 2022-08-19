using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 10;
    [SerializeField] public float currentHealth;
    public bool isAlive;

    void OnEnable()
    {
        currentHealth = maxHealth;
        isAlive = true;
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }
    
}
