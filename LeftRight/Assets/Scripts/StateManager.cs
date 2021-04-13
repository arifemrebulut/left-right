using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static States.GameState currentGameState;
    public static States.BallMovementState currentBallMovementState;

    #region Subscribe and Unsubscribe to events
    private void OnEnable()
    {
        EventBroker.OnTapInPlay += ChangeBallMovementState;
    }

    private void OnDisable()
    {
        EventBroker.OnTapInPlay -= ChangeBallMovementState;
    }
    #endregion

    private void ChangeBallMovementState(States.BallMovementState desiredBallMovementState)
    {
        currentBallMovementState = desiredBallMovementState;
    }
}
