using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private Text text;
    private Canvas canvas;

    private void Awake()
    {
        this.canvas = this.GetComponent<Canvas>();
    }

    public void Show(Camera camera)
    {
        this.background.SetActive(true);
        this.canvas.worldCamera = camera;
    }

    public void Vanish()
    {
        this.background.SetActive(false);
    }
}
