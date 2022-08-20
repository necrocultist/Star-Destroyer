using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject playerBullet;

    void Update()
    {
        ShootBullets();
    }

    void ShootBullets()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (bulletSpawnPoint != null && playerBullet != null)
            {
                Instantiate(playerBullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            }
            else
            {
                Debug.Log("Either Bullet Spawn Point Or Bullet Prefab Are Empty");
            }
        }
    }
}
