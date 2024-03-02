using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private Canvas canvas;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void Vanish()
    {
        this.background.SetActive(false);
    }

    public void StartGame()
    {
        StartCoroutine(WaitStart());
    }

    private IEnumerator WaitStart()
    {
        Vanish();
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1;
    }
}
