using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaEndMatch : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;

    public void Show()
    {
        this.canvas.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.canvas.gameObject.SetActive(false);
    }

    //criar bot�o que reinicia a partida ap�s fim

    //public void RestartGame()
    //{
    //    this.canvaEndMatch.Hide();
    //    Time.timeScale = 1;
    //    this.ball.Reset();
    //    this.score.Reset();
    //    this.player.Reset();
    //}
}
