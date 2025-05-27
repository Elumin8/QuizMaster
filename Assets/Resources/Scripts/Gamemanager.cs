using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    Quiz quiz;
    WinScreen winScreen;
    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        winScreen = FindObjectOfType<WinScreen>();
    }
    void Start()
    {
        quiz.gameObject.SetActive(true);
        winScreen.gameObject.SetActive(false);
    }


    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            winScreen.gameObject.SetActive(true);
            winScreen.ShowFinalScore();
        }
    }
    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
