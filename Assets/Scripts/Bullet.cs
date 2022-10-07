using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected int bulletDamage;
    [SerializeField] protected float bulletSpeed;
    [SerializeField] protected GameObject destroyEffect;
    [SerializeField] protected float destroyTime;

    void FixedUpdate()
    {
        MoveBullet();
    }

    protected void MoveBullet()
    {
        transform.Translate(new Vector2(0, bulletSpeed * Time.fixedDeltaTime));
    }

    protected virtual void OnCollisionEnter2D(Collision2D other)
    {
        // Do Something
    }

    protected void DestroyBullet()
    {
        Destroy(gameObject);
    }
}