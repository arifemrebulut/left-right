using System;
using UnityEngine;

public class EventBroker : MonoBehaviour
{
    public static Action<States.BallMovementState> OnTapInPlay;

    public static void CallOnTapInPlay(States.BallMovementState desiredBallMovementState)
    {
        OnTapInPlay(desiredBallMovementState);
    }
}
