using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private int contactDamage;

    [SerializeField] private GameObject bulletDestroyEffect;
    [SerializeField] private float bulletDestroyTime;

    private Vector3 scaleChange = new Vector3(0.17f, 0.17f, 0f);
    [SerializeField] private GameManager gm;
    public GameObject[] healths;
    private int index = 0;


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

        else
        {
            Destroy(healths[index]);
            index++;
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

    public void DestroyEnemyBullet(GameObject enemyBullet, Vector2 contact)
    {
        Destroy(enemyBullet);
        //enemyBullet.SetActive(false);
        GameObject destroyedObject = Instantiate(bulletDestroyEffect, contact, Quaternion.identity);
        Destroy(destroyedObject, bulletDestroyTime);
    }
}
