using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStraight : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    void FixedUpdate()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.Translate(new Vector2(0, enemySpeed * Time.fixedDeltaTime));
    }
}
