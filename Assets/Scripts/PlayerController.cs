using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 7;
    void Start()
    {
        
    }
    
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        Vector2 velocity = new Vector2(inputX, inputY);
        transform.Translate(velocity.normalized * moveSpeed * Time.deltaTime);
    }
}