using UnityEngine;

public class EnemyHealth : Character
{
    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;

        if (!AliveCheck())
        {
            Destroy(gameObject);
        }
    }
}