using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CanvaScore : MonoBehaviour
{
    [SerializeField]
    private Text goalsTaken;
    [SerializeField]
    private Text player1Score;
    [SerializeField]
    private Text player2Score;
    [SerializeField]
    public int Points { get; private set; }
    private BallMovement ball;
    [SerializeField]
    private PlayerMovement player1;
    [SerializeField]
    private PlayerMovement player2;
    [SerializeField]
    private CanvaEndMatch canvaEndMatch;
    [SerializeField]
    private Text winnerText;

    protected virtual void Start()
    {
        this.ball = Object.FindFirstObjectByType(typeof(BallMovement)) as BallMovement;
    }

    public void AddPoints()
    {
        this.Points++;
        this.goalsTaken.text = this.Points.ToString();
    }

    public void Reset()
    {
        this.Points = 0;
        this.goalsTaken.text = this.Points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        AddPoints();
        this.ball.Reset();
        this.player1.Reset();
        this.player2.Reset();

        if (Points >= 3)
        {
            EndGame();
            WinnerText();
        }
        else
        {
            StartCoroutine(NextPoint());
        }
    }

    private IEnumerator NextPoint()
    {
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1;
        this.ball.LaunchBall();
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        this.canvaEndMatch.Show();
    }

    private void WinnerText()
    {
        int score1 = int.Parse(player1Score.text);
        int score2 = int.Parse(player2Score.text);

        if (score1 > score2)
        {
            this.winnerText.text = "Player 1 Wins!!!";
        }
        else if (score1 < score2)
        {
            this.winnerText.text = "Player 2 Wins!!!";
        }
    }

}
