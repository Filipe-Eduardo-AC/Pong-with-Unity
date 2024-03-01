using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvaEndMatch : MonoBehaviour
{
    [SerializeField]
    private Text endText;
    private CanvaScore score;

    private void Start()
    {
        this.score = Object.FindFirstObjectByType(typeof(CanvaScore)) as CanvaScore;
    }

    public void Show()
    {
        this.endText.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.endText.gameObject.SetActive(false);
    }
}
