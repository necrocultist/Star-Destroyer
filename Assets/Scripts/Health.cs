using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public int currentHealth;
    public bool isAlive;

    void OnEnable()
    {
        ResetHealth();
        isAlive = true;
    }

    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;
    }

    public void IncreaseHealth(int refill)
    {
        currentHealth += refill;
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
