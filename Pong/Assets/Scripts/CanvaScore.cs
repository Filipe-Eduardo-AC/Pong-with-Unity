using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CanvaScore : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    public int Points { get; private set; }
    private BallMovement ball;
    [SerializeField]
    private PlayerMovement player1;
    [SerializeField]
    private PlayerMovement player2;

    protected virtual void Start()
    {
        this.ball = Object.FindFirstObjectByType(typeof(BallMovement)) as BallMovement;
    }

    public void AddPoints()
    {
        this.Points++;
        this.scoreText.text = this.Points.ToString();
    }

    public void Reset()
    {
        this.Points = 0;
        this.scoreText.text = this.Points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        AddPoints();
        this.ball.Reset();
        this.player1.Reset();
        this.player2.Reset();
        StartCoroutine(NextPoint());
    }

    private IEnumerator NextPoint()
    {
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1;
        this.ball.LaunchBall();
    }
}
