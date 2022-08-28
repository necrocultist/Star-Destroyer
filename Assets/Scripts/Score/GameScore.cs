using System;
using TMPro;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float scorePerSecond;
<<<<<<< HEAD
    [SerializeField] private GameManager gm;

=======
>>>>>>> c9ec327a1e8a11ce5f5baaba02702dd7b29489ba
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
