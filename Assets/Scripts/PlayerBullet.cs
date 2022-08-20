using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float playerBulletSpeed;

    void FixedUpdate()
    {
        PlayerBulletMove();
    }

    void PlayerBulletMove()
    {
        transform.Translate(new Vector2(0, playerBulletSpeed * Time.fixedDeltaTime));
    }
}
