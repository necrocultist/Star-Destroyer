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
        float velocityX = inputX * moveSpeed;
        transform.Translate(Vector2.right * velocityX * Time.deltaTime);
        
        float inputY = Input.GetAxisRaw("Vertical");
        float velocityY = inputY * moveSpeed;
        transform.Translate(Vector2.up * velocityY * Time.deltaTime);
    }
}
