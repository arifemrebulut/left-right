using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && StateManager.currentGameState == States.GameState.OnPlay)
        {
            if (StateManager.currentBallMovementState == States.BallMovementState.Patrol)
            {
                EventBroker.CallOnTapInPlay(States.BallMovementState.Left);
            }
            else if (StateManager.currentBallMovementState == States.BallMovementState.Left)
            {
                EventBroker.CallOnTapInPlay(States.BallMovementState.Right);
            }
            else if (StateManager.currentBallMovementState == States.BallMovementState.Right)
            {
                EventBroker.CallOnTapInPlay(States.BallMovementState.Left);
            }
        }
    }
}
