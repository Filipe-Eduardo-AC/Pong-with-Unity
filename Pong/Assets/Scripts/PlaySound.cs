using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{
    [SerializeField]
    private AudioClip audioClipRacket;
    [SerializeField]
    private AudioClip audioClipWall;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HitRacketSFX();
        }
        else
        {
            HitWallSFX();
        }
    }


    private void HitRacketSFX()
    {
        audioSource.PlayOneShot(audioClipRacket);
    }

    private void HitWallSFX()
    {
        audioSource.PlayOneShot(audioClipWall);
    }
}
