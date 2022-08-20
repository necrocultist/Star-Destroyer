using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float scorePerSecond;
    private float score;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = ((int)score).ToString();
        score += scorePerSecond * Time.deltaTime;
    }
}
