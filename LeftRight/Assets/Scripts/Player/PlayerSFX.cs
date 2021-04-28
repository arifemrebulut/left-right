using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    AudioSource audioSource;

    #region Subscribe and unsubscribe to events
    private void OnEnable()
    {
        EventBroker.OnTapInPlay += PlayTapSound;
    }

    private void OnDisable()
    {
        EventBroker.OnTapInPlay -= PlayTapSound;
    }
    #endregion

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void PlayTapSound()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
