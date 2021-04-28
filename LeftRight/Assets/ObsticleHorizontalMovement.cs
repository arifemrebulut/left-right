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

    void Update()
    {
        MoveObsticle();
    }

    private void MoveObsticle()
    {
        if (movementDirection == MovementDirection.Left)
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime, Space.World);
        }
    }
}
