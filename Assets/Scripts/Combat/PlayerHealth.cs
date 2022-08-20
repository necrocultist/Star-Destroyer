using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int currentHealth;
    [SerializeField] private int contactDamage;

    private Vector3 scaleChange = new Vector3(0.2f, 0.2f, 0f);
    [SerializeField] private GameManager gm;


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

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out EnemyHealth enemy) || gameObject.TryGetComponent(out EnemySpawner _))
            {
                enemy.DestroyObject();
                DecraseHealth(contactDamage);
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
}
