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

        if (other.gameObject != null)
        {
            if (gameObject.TryGetComponent(out PlayerHealth player) || gameObject.TryGetComponent(out PlayerGun _))
            {

                player.DecraseHealth(enemyBulletDamage);

                player.DestroyEnemyBullet(this.gameObject, contactPoint);
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }

    //private void DestroyBullet()
    //{

    //}

    //public void DestroyEnemyBullet(Vector2 player)
    //{
    //    gameObject.SetActive(false);
    //    GameObject destroyedObject = Instantiate(bulletDestroyEffect, player, Quaternion.identity);
    //    Destroy(destroyedObject, destroyTime);
    //}
}
