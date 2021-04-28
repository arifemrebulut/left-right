using UnityEngine;

public enum ObsticleRotationDirection
{
    Clockwise,
    AntiClockwise
}

public class ObsticleRotation : MonoBehaviour
{
    [SerializeField] private float constSpeed;
    [SerializeField] private bool randomSpeed;

    [SerializeField] private float randomSpeedMin;
    [SerializeField] private float randomSpeedMax;

    private float rotationSpeed;

    private ObsticleRotationDirection direction;

    private void Start()
    {
        CalculateDirection();
    }

    void Update()
    {
        RotateObsticle();   
    }

    private void CalculateDirection()
    {
        direction = (ObsticleRotationDirection)Random.Range(0,2);

        if (!randomSpeed && direction == ObsticleRotationDirection.AntiClockwise)
        {
            rotationSpeed = constSpeed;
        }
        else if (!randomSpeed && direction == ObsticleRotationDirection.Clockwise)
        {
            rotationSpeed = -constSpeed;
        }
        else if (randomSpeed && direction == ObsticleRotationDirection.AntiClockwise)
        {
            rotationSpeed = Random.Range(randomSpeedMax, randomSpeedMin);
        }
        else if (randomSpeed && direction == ObsticleRotationDirection.Clockwise)
        {
            rotationSpeed = -Random.Range(randomSpeedMin, randomSpeedMax);
        }
    }

    private void RotateObsticle()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
