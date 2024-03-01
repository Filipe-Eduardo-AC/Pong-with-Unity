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
}
