using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int enemyBulletDamage;
    [SerializeField] private float bulletSpeed;

    void FixedUpdate()
    {
        transform.Translate(new Vector2(0, bulletSpeed * Time.fixedDeltaTime));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;
        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out Health player) && gameObject.GetComponent<PlayerController>() != null)
            {
                player.DecraseHealth(enemyBulletDamage);
                if (player.currentHealth <= 0)
                {
                    player.isAlive = false;
                }
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
}
