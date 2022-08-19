using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField] private float moveSpeed;
=======
    public float moveSpeed = 7;
    
>>>>>>> Stashed changes
    
    void Update()
    {

    }

    void FixedUpdate()
    {
        MovePlayer(GetPlayerInput());
    }

    Vector2 GetPlayerInput()
    {
        return new Vector2(UnityEngine.Input.GetAxisRaw("Horizontal"), UnityEngine.Input.GetAxisRaw("Vertical"));
    }

    void MovePlayer(Vector2 playerVelocity)
    {
        transform.Translate(moveSpeed * Time.deltaTime * playerVelocity.normalized);
    }

}