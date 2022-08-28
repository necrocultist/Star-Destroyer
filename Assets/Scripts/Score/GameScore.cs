using System;
using TMPro;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float scorePerSecond;
    [SerializeField] private GameManager gm;

    private float score;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        if (gm.currentState == States.Playing)
        {
            ScorePanel();
        }
        else if (gm.currentState == States.Fail)
        {
            ScoreEndPanel();
        }
    }

    private void ScoreEndPanel()
    {
        scoreText.text = "Score: " + ((int)score).ToString();
        score += scorePerSecond * Time.deltaTime;
    }

    private void ScorePanel()
    {
        scoreText.text = ((int)score).ToString();
        score += scorePerSecond * Time.deltaTime;
    }
}
