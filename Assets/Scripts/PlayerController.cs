using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    void FixedUpdate()
    {
        MovePlayer(GetPlayerInput());
    }

    Vector2 GetPlayerInput()
    {
        return new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
    }

    void MovePlayer(Vector2 playerVelocity)
    {
        transform.Translate(moveSpeed * Time.deltaTime * playerVelocity.normalized);
    }

}