using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float scorePerSecond;

    private float score;
    [Range(1, 2)]
    [SerializeField] private int scoreSelection;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        switch (scoreSelection)
        {
            case 1:
                ScorePanel();
                break;

            case 2:
                ScoreEndPanel();
                break;
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
