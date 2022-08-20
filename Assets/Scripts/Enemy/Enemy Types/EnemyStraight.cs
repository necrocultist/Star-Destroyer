using UnityEngine;

public class EnemyStraight : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    void FixedUpdate()
    {
        MoveEnemyDown();
    }

    private void MoveEnemyDown()
    {
        transform.Translate(new Vector2(0, enemySpeed * Time.fixedDeltaTime));
    }
}
