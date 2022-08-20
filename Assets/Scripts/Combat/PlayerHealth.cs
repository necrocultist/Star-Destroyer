using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public int currentHealth;

    private Vector3 scaleChange = new Vector3(0.2f, 0.2f, 0f);
    public GameManager gm;


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
            gm.currentState = States.Fail;
        }

        transform.localScale += scaleChange;
        
    }

    public void IncreaseHealth(int refill)
    {
        currentHealth += refill;
    }

    public bool AliveCheck()
    {
        return currentHealth > 0;
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }

    private void ResetHealth()
    {
        currentHealth = maxHealth;
    }
}
