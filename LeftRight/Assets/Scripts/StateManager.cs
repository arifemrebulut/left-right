using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static States.GameState currentGameState { get; private set; }
    public static States.BallMovementState currentBallMovementState { get; private set; }

    public void ChangeGameState(States.GameState desiredGameState)
    {
        currentGameState = desiredGameState;
    }

    private void ChangeBallMovementState(States.BallMovementState desiredBallMovementState)
    {
        currentBallMovementState = desiredBallMovementState;
    }
}
