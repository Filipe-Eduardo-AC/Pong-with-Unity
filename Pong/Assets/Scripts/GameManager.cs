using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BallMovement ball;
    private CanvaScore score;
    private CanvaEndMatch canvaEndMatch;
    private PlayerMovement player;

    protected virtual void Start()
    {
        this.ball = Object.FindFirstObjectByType(typeof(BallMovement)) as BallMovement;
        this.score = Object.FindFirstObjectByType(typeof(CanvaScore)) as CanvaScore;
        this.canvaEndMatch = Object.FindFirstObjectByType(typeof(CanvaEndMatch)) as CanvaEndMatch;
        this.player = Object.FindFirstObjectByType(typeof(PlayerMovement)) as PlayerMovement;
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        this.canvaEndMatch.Show();
    }

    public virtual void RestartGame()
    {
        this.canvaEndMatch.Hide();
        Time.timeScale = 1;
        this.ball.Reset();
        this.score.Reset();
        this.player.Reset();
    }
}
