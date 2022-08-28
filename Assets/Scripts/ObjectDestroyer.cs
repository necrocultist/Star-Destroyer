using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject target = collision.gameObject;
        Destroy(target);
    }
}
