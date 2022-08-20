using UnityEngine;

public class EnemyStraight : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    void FixedUpdate()
    {
        MoveEnemyStraight();
    }

    private void MoveEnemyStraight()
    {
        transform.Translate(new Vector2(0, enemySpeed * Time.fixedDeltaTime));
    }
}
