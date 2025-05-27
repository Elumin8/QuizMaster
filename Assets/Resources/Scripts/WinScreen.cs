using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class WinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreKeeper scoreKeeper;
    [SerializeField]TextMeshProUGUI congatulationText;
    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();


    }

    public void ShowFinalScore()
    {
        
        congatulationText.text = "Congratulation!\n You score : " + scoreKeeper.CalculateScore() + "%";
    }

}
