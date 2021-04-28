using System;
using UnityEngine;

public class EventBroker : MonoBehaviour
{
    public static Action OnTapInPlay;
    public static Action OnPlayerDie;
    public static Action OnGameRestart;

    // Events for creating and destroying level prefabs
    public static Action<GameObject> OnCreaterLevelEndPoint;
    public static Action<GameObject> OnDestroyerLevelEndPoint;

    public static void CallOnTapInPlay()
    {
        OnTapInPlay();
    }

    public static void CallOnPlayerDie()
    {
        OnPlayerDie();
    }

    public static void CallOnGameRestart()
    {
        Debug.Log("RestartGame");
        OnGameRestart();
    }

    public static void CallOnCreaterLevelEndPoint(GameObject collidedLevel)
    {
        OnCreaterLevelEndPoint(collidedLevel);
    }

    public static void CallOnDestroyerLevelEndPoint(GameObject collidedLevel)
    {
        OnDestroyerLevelEndPoint(collidedLevel);
    }
}
