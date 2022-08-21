using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRightLeft : MonoBehaviour
{
    [SerializeField] private float enemyYAxisSpeed;
    [SerializeField] private float enemyXAxisSpeed;
    [SerializeField] private float toPlayerOffset;
    [SerializeField] private Transform player;
    private void FixedUpdate()
    {
        MoveEnemyRightLeft();
        if (player != null)
        {
            if ((transform.position.y - player.position.y) > toPlayerOffset)
            {
                MoveEnemyDown();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.layer == 3)
        {
            enemyXAxisSpeed *= -1;
        }
    }

    private void MoveEnemyRightLeft()
    {
        transform.Translate(new Vector2(enemyXAxisSpeed * Time.fixedDeltaTime, 0));
    }

    private void MoveEnemyDown()
    {
        transform.Translate(new Vector2(0, enemyYAxisSpeed * Time.fixedDeltaTime));
    }
}
