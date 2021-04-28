using UnityEngine;

public class PlayGameMusic : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        PlayMusic();
    }

    private void PlayMusic()
    {
        audioSource.Play();
    }
}
