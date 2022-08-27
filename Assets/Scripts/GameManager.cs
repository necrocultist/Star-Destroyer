using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum States
{
    TapToStart,
    Playing,
    Fail
}

public class GameManager : MonoBehaviour
{
    public States currentState;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private PlayerHealth ph;

    private void OnEnable()
    {
         
    }

    void Start()
    {
        Time.timeScale = 0;
        currentState = States.TapToStart;
    }

    void Update()
    {
        switch (currentState)
        {
            case States.TapToStart:
                startPanel.SetActive(true);
                gamePanel.SetActive(false);
                endPanel.SetActive(false);
                break;
            case States.Playing:
                startPanel.SetActive(false);
                gamePanel.SetActive(true);
                break;
            case States.Fail:
                Time.timeScale = 0;
                gamePanel.SetActive(false);
                endPanel.SetActive(true);
                break;
        }
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
        currentState = States.Playing;
        Time.timeScale = 1;
    }

    public void StatetoFail()
    {
        currentState = States.Fail;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
