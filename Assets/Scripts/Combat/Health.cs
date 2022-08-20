using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [HideInInspector]public bool isAlive;
    public int currentHealth;

    private void OnEnable()
    {
        ResetHealth();
        isAlive = true;
    }

    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;

        if (!AliveCheck())
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseHealth(int refill)
    {
        currentHealth += refill;
    }

    private bool AliveCheck()
    {
        return currentHealth > 0;
    }


    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
