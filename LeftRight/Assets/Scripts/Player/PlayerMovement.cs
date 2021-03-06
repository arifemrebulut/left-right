using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Speed")]
    [SerializeField] private float upMovementSpeed;
    [SerializeField] private float leftRightSpeed;

    [Header("Patrolling Settings")]
    [SerializeField] private float patrolBound;
    [SerializeField] private float patrolSpeed;

    private float[] patrolPoints;
    private float currentPatrolPoint;

    private void OnEnable()
    {
        EventBroker.OnGameRestart += ResetPlayerPosition;
    }

    private void OnDisable()
    {
        EventBroker.OnGameRestart -= ResetPlayerPosition;
    }

    private void Start()
    {
        patrolPoints = new float[2];
        patrolPoints[0] = -patrolBound;
        patrolPoints[1] = patrolBound;
        currentPatrolPoint = patrolPoints[0];
    }

    private void Update()
    {
        if (States.currentGameState == States.GameState.OnStart)
        {
            PatrolOnStart();
        }

        if (States.currentGameState == States.GameState.OnPlay)
        {
            UpMovement();

            SidewaysMovement();
        }
    }

    private void PatrolOnStart()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(currentPatrolPoint, transform.position.y), patrolSpeed * Time.deltaTime);

        if (transform.position.x <= -patrolBound)
        {
            currentPatrolPoint = patrolPoints[1];
        }
        if (transform.position.x >= patrolBound)
        {
            currentPatrolPoint = patrolPoints[0];
        }
    }

    private void UpMovement()
    {
        transform.Translate(Vector2.up * upMovementSpeed * Time.deltaTime);
    }

    private void SidewaysMovement()
    {
        if (States.currentBallMovementState == States.BallMovementState.Left)
        {
            MoveLeft();
        }
        else if (States.currentBallMovementState == States.BallMovementState.Right)
        {
            MoveRight();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * leftRightSpeed * Time.deltaTime);
    }

    private void MoveRight()
    {
        transform.Translate(Vector2.right * leftRightSpeed * Time.deltaTime);
    }

    private void ResetPlayerPosition()
    {
        transform.position = Vector3.zero;
    }
}
