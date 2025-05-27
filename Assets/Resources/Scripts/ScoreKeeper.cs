using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }
    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }
    public int GetQuestionSeen()
    {
        return questionSeen;
    }
    public int IncrementQuestionSeen()
    {
        return questionSeen++;
    }
    public int CalculateScore()
    {
        return ( correctAnswers * 100) / questionSeen;
    }




    public int QuestionSeen
    {
        get
        {
            return questionSeen;
        }
        set
        {
            questionSeen++;
        }
    }
   
}
