using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int currentHealth;
    [SerializeField] protected GameObject bulletDestroyEffect;
    [SerializeField] private float bulletDestroyTime;

    protected virtual void OnEnable()
    {
        ResetHealth();
    }

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

   public void CreateBulletDestroyEffect(Vector2 contactPoint)
    {
        GameObject destroyEffect = Instantiate(bulletDestroyEffect, contactPoint, Quaternion.identity);
        Destroy(destroyEffect, bulletDestroyTime);
    }
}