using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TF_GameMaster : MonoBehaviour
{
    public Text qDisplay, resultText;

    public string[] questions;
    public bool[] answers;

    int question_index, previousQ;

    bool playeranswer;

    private void Start()
    {
        GenerateQuestion();    
    }

    public void GenerateQuestion()
    {
        previousQ = question_index;
        while(question_index == previousQ)
        {
            question_index = Random.Range(0, questions.Length);
        }
        Debug.Log(question_index);
        qDisplay.text = questions[question_index];

    }

    public void CheckAnswer()
    {
        if(playeranswer == answers[question_index])
        {
            resultText.text = "CORRECT";
        }
        else
        {
            resultText.text = "WRONG";
        }

    }

    public void AnswerTrue()
    {
        playeranswer = true;
        CheckAnswer();
        GenerateQuestion();
    }
    public void AnswerFalse()
    {
        playeranswer = false;
        CheckAnswer();
        GenerateQuestion();
    }

    
}
