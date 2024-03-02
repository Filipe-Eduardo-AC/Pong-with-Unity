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
    private CanvaScore goal1;
    [SerializeField]
    private CanvaScore goal2;

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
        this.goal1.ResetScore();
        this.goal2.ResetScore();
        this.canvaMenu.StartGame();
    }
}
