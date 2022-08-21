using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private GameObject playerBullet;
    [SerializeField] private GameManager gm;

    void Update()
    {
        ShootBullets();
    }

    void ShootBullets()
    {
        if (Input.GetMouseButtonDown(0) && gm.currentState == States.Playing)
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