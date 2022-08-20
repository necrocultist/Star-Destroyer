using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private GameObject playerBullet;

    void Update()
    {
        ShootBullets();
    }

    void ShootBullets()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (playerBullet != null)
            {
                Instantiate(playerBullet, transform.position, transform.rotation);
            }
            else
            {
                Debug.Log("Either Bullet Spawn Point Or Bullet Prefab Are Empty");
            }
        }
    }
}
