using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPS_GameMaster : MonoBehaviour
{
    int playerScore, comScore;
    public Text PScore, CScore, resultsText;
    enum moves
    {
        rock,
        paper,
        scissors
    }

    moves playerMove, comMove;

    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        playerScore = 0;
        comScore = 0;
        resultsText.text = null;
        PScore.text = playerScore.ToString();
        CScore.text = comScore.ToString();
    }

    public void PickRock() { playerMove = moves.rock; COMMove(); }
    public void PickPaper() { playerMove = moves.paper; COMMove(); }
    public void PickScissors() { playerMove = moves.scissors; COMMove(); }

    public void COMMove()
    {
        int move = Random.Range(0, 3);

        switch (move)
        {
            case 0:
                comMove = moves.rock;
                break;
            case 1:
                comMove = moves.paper;
                break;
            case 2:
                comMove = moves.scissors;
                break;
        }

        Debug.Log(comMove);
        RunResults();
    }

    public void RunResults()
    {
        switch (playerMove)
        {
            case moves.rock:
                if (comMove == moves.scissors) { playerScore++; resultsText.text = "PLAYER WINS"; }
                else if (comMove == moves.paper) { comScore++; resultsText.text = "COM WINS"; }
                else resultsText.text = "TIE";
                break;
            case moves.paper:
                if (comMove == moves.rock) { playerScore++; resultsText.text = "PLAYER WINS"; }
                else if (comMove == moves.scissors) { comScore++; resultsText.text = "COM WINS"; }
                else resultsText.text = "TIE";
                break;
            case moves.scissors:
                if (comMove == moves.paper) { playerScore++; resultsText.text = "PLAYER WINS"; }
                else if (comMove == moves.rock) { comScore++; resultsText.text = "COM WINS"; }
                else resultsText.text = "TIE";
                break;
        }

        PScore.text = playerScore.ToString();
        CScore.text = comScore.ToString();
    }

}
