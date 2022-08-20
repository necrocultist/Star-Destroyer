using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int enemyBulletDamage;
    [SerializeField] private float bulletSpeed;

    void FixedUpdate()
    {
        transform.Translate(new Vector2(0, bulletSpeed * Time.fixedDeltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;
        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out Health playerHealth))
            {
                playerHealth.DecraseHealth(enemyBulletDamage);
                if (playerHealth.currentHealth <= 0)
                {
                    playerHealth.isAlive = false;
                }
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
}
