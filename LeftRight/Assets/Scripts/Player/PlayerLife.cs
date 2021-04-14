using UnityEngine;

public class PlayerLife : MonoBehaviour, IDieable
{
    [SerializeField] GameObject playerBody;

    private void OnEnable()
    {
        EventBroker.OnGameRestart += EnablePlayerBody;
    }

    private void OnDisable()
    {
        EventBroker.OnGameRestart -= DisablePlayerBody;
    }

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

    private void EnablePlayerBody()
    {
        playerBody.SetActive(true);
    }

    private void DisablePlayerBody()
    {
        playerBody.SetActive(false);
    }
}
