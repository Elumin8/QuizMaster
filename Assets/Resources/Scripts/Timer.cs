using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{


    [SerializeField] float timeToComplete = 30f;
    [SerializeField] float timeToShowCorrect = 10f;

    public bool isAnsweringQuestion;
    float timerValue;
    public float fillFraction;
    public bool loadNextQuestion;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }
    void UpdateTimer()
    {   
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion) {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToComplete;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrect;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrect;
            }
            else
            {

                isAnsweringQuestion = true;
                timerValue = timeToComplete;
                loadNextQuestion = true;
            }
        }

        // Debug.Log(isAnsweringQuestion + ":" +  timerValue + "=" + fillFraction );
    }
}
