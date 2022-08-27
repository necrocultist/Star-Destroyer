using UnityEngine;

public class PlayerHealth : Health
{
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
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
