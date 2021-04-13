using UnityEngine;

public class PlayerLife : MonoBehaviour, IDieable
{
    [SerializeField] GameObject playerBody;

    public void Die()
    {
        DisablePlayerBody();

        ChangeGameStateToGameOver();

        EventBroker.CallOnPlayerDie();
    }

    private void ChangeGameStateToGameOver()
    {
        States.currentGameState = States.GameState.OnGameOver;
    }

    private void DisablePlayerBody()
    {
        playerBody.SetActive(false);
    }
}
