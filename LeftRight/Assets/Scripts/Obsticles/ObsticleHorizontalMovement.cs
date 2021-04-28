using UnityEngine;

public enum MovementDirection
{
    Left,
    Right
}

public class ObsticleHorizontalMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private MovementDirection movementDirection;
    [SerializeField] private float triggerTimeInSeconds;

    private bool canMove = false;

    void Update()
    {
        CountDown();

        MoveObsticle();
    }

    private void MoveObsticle()
    {
        if (movementDirection == MovementDirection.Left && canMove)
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime, Space.World);
        }
        else if (movementDirection == MovementDirection.Right && canMove)
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime, Space.World);
        }
    }

    private void CountDown()
    {
        triggerTimeInSeconds -= Time.deltaTime;

        if (triggerTimeInSeconds <= 0)
        {
            canMove = true;
        }
        else
        {
            canMove = false;
        }
    }
}
