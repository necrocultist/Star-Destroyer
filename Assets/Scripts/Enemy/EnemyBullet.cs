using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int enemyBulletDamage;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject bulletDestroyEffect;
    [SerializeField] private float destroyTime;

    void FixedUpdate()
    {
        transform.Translate(new Vector2(0, bulletSpeed * Time.fixedDeltaTime));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;
        Vector2 contactPoint = other.GetContact(0).point;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out Health player) && gameObject.GetComponent<PlayerController>() != null)
            {
                player.DecraseHealth(enemyBulletDamage);
                if (player.currentHealth <= 0)
                {
                    player.isAlive = false;
                }

                DestroyEnemyBullet(contactPoint);
                DestroyBullet();
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }

    private void DestroyEnemyBullet(Vector2 player)
    {
        gameObject.SetActive(false);
        GameObject destroyedObject = Instantiate(bulletDestroyEffect, player, Quaternion.identity);
        Destroy(destroyedObject, destroyTime);
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
