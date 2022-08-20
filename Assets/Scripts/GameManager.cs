using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
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
                endPanel.SetActive(false);
                break;
            case States.Fail:
                Time.timeScale = 0;
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

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
