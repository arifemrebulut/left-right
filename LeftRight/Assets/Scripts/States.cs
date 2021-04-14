

public static class States
{
    public enum GameState
    {
        OnStart,
        OnPlay,
        OnGameOver
    }

    public enum BallMovementState
    {
        Patrol,
        Left,
        Right
    }

    public static GameState currentGameState;
    public static BallMovementState currentBallMovementState;

    public static void ResetStates()
    {
        currentGameState = GameState.OnStart;
        currentBallMovementState = BallMovementState.Patrol;
    }
}
