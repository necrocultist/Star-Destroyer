using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States
{
    TapToStart,
    Playing,
    Fail,
    Win
}

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] private GameObject finishPanel;
    public States currentState;
    
    void Start()
    {
        currentState = States.TapToStart;
        startPanel.SetActive(true);
        finishPanel.SetActive(false);
    }

    void Update()
    {
        switch (currentState)
        {
            case States.Playing:
                startPanel.SetActive(false);
                finishPanel.SetActive(false);
                break;
            case States.Fail:
                startPanel.SetActive(false);
                finishPanel.SetActive(true);
                break;
        }
    }
}
