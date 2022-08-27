using Unity.VisualScripting;
using UnityEngine;

public class EnemyBullet : Bullet
{
    protected override void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;
        Vector2 contactPoint = other.GetContact(0).point;

        if (other.gameObject != null)
        {
            if (gameObject.TryGetComponent(out PlayerHealth player) || gameObject.TryGetComponent(out PlayerGun _))
            {

                player.DecraseHealth(bulletDamage);

                DestroyBullet(contactPoint);
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
}
