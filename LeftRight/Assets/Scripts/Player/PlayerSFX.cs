using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    [SerializeField] private AudioClip[] playerDeathSounds;

    AudioSource audioSource;

    #region Subscribe and unsubscribe to events
    private void OnEnable()
    {
        EventBroker.OnTapInPlay += PlayTapSound;
        EventBroker.OnPlayerDie += PlayPlayerDeathSound;
    }

    private void OnDisable()
    {
        EventBroker.OnTapInPlay -= PlayTapSound;
        EventBroker.OnPlayerDie -= PlayPlayerDeathSound;
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

    private void PlayPlayerDeathSound()
    {
        int randomSoundIndex = Random.Range(0, playerDeathSounds.Length);

        audioSource.PlayOneShot(playerDeathSounds[randomSoundIndex]);
    }
}
