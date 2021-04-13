using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IDieable dieable = collision.gameObject.GetComponentInParent<IDieable>();

        if (dieable != null)
        {
            dieable.Die();
        }
    }
}
