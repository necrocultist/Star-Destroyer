using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;

    void Start()
    {
        ResetScore();
    }

    private void ResetScore()
    {
        score = 0;
    }

    void FixedUpdate()
    {
        
    }
}
