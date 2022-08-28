using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float asteroidDestroyTime;
    [SerializeField] private GameObject bulletDestroyEffect;
    [SerializeField] private float bulletDestroyTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject target = collision.gameObject;

        if (target != null)
        {
            if (target.TryGetComponent(out PlayerHealth player) || target.TryGetComponent(out PlayerBulletSpawner _))
            {
                player.DecraseHealth(player.GetContactDamage());

                Destroy(gameObject, asteroidDestroyTime);
            }
        }
    }

    public void CreateBulletDestroyEffect(Vector2 contactPoint)
    {
        GameObject destroyEffect = Instantiate(bulletDestroyEffect, contactPoint, Quaternion.identity);
        Destroy(destroyEffect, bulletDestroyTime);
    }
}