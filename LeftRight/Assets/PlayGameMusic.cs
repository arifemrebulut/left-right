using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGameMusic : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        PlayMusic();
    }

    private void PlayMusic()
    {
        audioSource.Play();
    }
}
