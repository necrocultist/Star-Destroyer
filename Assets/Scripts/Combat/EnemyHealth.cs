using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int currentHealth;

    private void OnEnable()
    {
        ResetHealth();
    }

    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;

        if (!AliveCheck())
        {
            DestroyObject();
        }
    }

    public void IncreaseHealth(int refill)
    {
        currentHealth += refill;
    }

    public bool AliveCheck()
    {
        return currentHealth > 0;
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
