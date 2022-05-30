using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text player1Score;
    public Text player2Score;
    private int player1Points = 0;
    private int player2Points = 0;
    int addScore1 =0;
    int addScore2 =0;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score Added");
        player1Score.text = "Player  : " + 0;
        player2Score.text = "Computer : " + 0;
    }

    public void updateScore1(int playerScore1)
    {
        Debug.Log("Player 1 Score updated");
        Debug.Log(playerScore1);
        player1Score.text = "Player :" + playerScore1.ToString();
    }

    public void updateScore2(int playerScore2)
    {
        Debug.Log("Computer Score updated");
        player2Score.text = "Computer : " + playerScore2.ToString();
    }

    public void AddScore1(int points)
    {
        Debug.Log("Score 1 Added");
        addScore1 += points;
        updateScore1(addScore1);
        ResetPosition();
    }
    public void AddScore2(int points2)
    {
        Debug.Log("Score 2 Added");
        addScore2 += points2;
        updateScore2(addScore2);
        ResetPosition();
    }

    private void ResetPosition()
    {
        GameObject.Find("Circle").GetComponent<ball>().Reset();
        GameObject.Find("Player1").GetComponent<player>().Reset();
        GameObject.Find("Player2").GetComponent<computer_player>().Reset();
    }

   

    


}

