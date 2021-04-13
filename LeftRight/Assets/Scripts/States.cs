

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

    public static States.GameState currentGameState;
    public static States.BallMovementState currentBallMovementState;
}
