using UnityEngine;

public class EnemyHealth : Health
{
    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;

        if (!AliveCheck())
        {
            DestroyObject();
        }
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
