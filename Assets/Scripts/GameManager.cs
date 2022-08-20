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
        }
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
        currentState = States.Playing;
    }
}
