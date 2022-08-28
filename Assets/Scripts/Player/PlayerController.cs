using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody2D playerRigidBody;
    private Vector2 inputDirection;

    private void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetPlayerInput();
    }

    private void FixedUpdate()
    {
        MovePlayer(inputDirection);
    }

    private void GetPlayerInput()
    {
        inputDirection = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
    }

    private void MovePlayer(Vector2 direction)
    {
        playerRigidBody.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.fixedDeltaTime));
    }

}