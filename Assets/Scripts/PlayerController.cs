using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    
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