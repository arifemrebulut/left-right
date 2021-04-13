using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && States.currentGameState == States.GameState.OnPlay)
        {
            if (States.currentBallMovementState == States.BallMovementState.Patrol)
            {
                States.currentBallMovementState = States.BallMovementState.Left;
            }
            else if (States.currentBallMovementState == States.BallMovementState.Left)
            {
                States.currentBallMovementState = States.BallMovementState.Right;
            }
            else if (States.currentBallMovementState == States.BallMovementState.Right)
            {
                States.currentBallMovementState = States.BallMovementState.Left;
            }
        }
    }
}
