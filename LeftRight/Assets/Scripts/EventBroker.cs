using System;
using UnityEngine;

public class EventBroker : MonoBehaviour
{
    public static Action OnTapInPlay;
    public static Action OnPlayerDie;

    public static void CallOnTapInPlay()
    {
        OnTapInPlay();
    }

    public static void CallOnPlayerDie()
    {
        OnPlayerDie();
    }
}
