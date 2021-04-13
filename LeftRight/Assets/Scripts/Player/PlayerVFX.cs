using UnityEngine;

public class PlayerVFX : MonoBehaviour
{
    [SerializeField] private GameObject playerDeathParticleEffect;

    private void OnEnable()
    {
        EventBroker.OnPlayerDie += PlayParticleEffect;
    }

    private void OnDisable()
    {
        EventBroker.OnPlayerDie -= PlayParticleEffect;
    }

    private void PlayParticleEffect()
    {
        Instantiate(playerDeathParticleEffect, transform.position, Quaternion.identity);
    }
}
