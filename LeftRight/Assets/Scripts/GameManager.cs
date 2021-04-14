using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;

    public void RestartGame()
    {
        States.ResetStates();
        EventBroker.CallOnGameRestart();
    }
}