using UnityEngine;

public class PlayerBullet : Bullet
{
    protected override void OnCollisionEnter2D(Collision2D other)
    {
        // Do something from the base method then add below

        GameObject gameObject = other.gameObject;
        Vector2 contactPoint = other.GetContact(0).point;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out EnemyHealth enemy))
            {
                enemy.DecraseHealth(bulletDamage);

                DestroyBullet();

                enemy.CreateBulletDestroyEffect(contactPoint);

            }
            else if (gameObject.TryGetComponent(out Asteroid asteroid))
            {
                asteroid.CreateBulletDestroyEffect(contactPoint);

                DestroyBullet();
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
}