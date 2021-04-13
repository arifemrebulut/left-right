using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static States.GameState currentGameState { get; private set; }
    public static States.BallMovementState currentBallMovementState { get; private set; }


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

    public void ChangeGameState(States.GameState desiredGameState)
    {
        currentGameState = desiredGameState;
    }

    private void ChangeBallMovementState(States.BallMovementState desiredBallMovementState)
    {
        currentBallMovementState = desiredBallMovementState;
    }
}
