using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaEndMatch : MonoBehaviour
{
    [SerializeField]
    private Canvas canvaEnd;
    [SerializeField]
    private CanvaMenu canvaMenu;
    [SerializeField]
    private CanvaScore canvaScore;

    public void Show()
    {
        this.canvaEnd.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.canvaEnd.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        Hide();
        this.canvaScore.ResetScore();
        this.canvaMenu.StartGame();
    }
}
