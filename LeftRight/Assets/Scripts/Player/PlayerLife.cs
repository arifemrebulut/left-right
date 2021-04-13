using UnityEngine;

public class PlayerLife : MonoBehaviour, IDieable
{
    [SerializeField] GameObject playerBody;

    public void Die()
    {
        DisablePlayerBody();

        EventBroker.CallOnPlayerDie();
    }

    private void DisablePlayerBody()
    {
        playerBody.SetActive(false);
    }
}
