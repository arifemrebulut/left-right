using System;
using UnityEngine;

public class EventBroker : MonoBehaviour
{
    public static Action OnTapInPlay;

    public static void CallOnTapInPlay()
    {
        OnTapInPlay();
    }
}
