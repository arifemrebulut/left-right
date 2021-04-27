using UnityEngine;

public enum ObsticleRotationDirection
{
    Clockwise,
    AntiClockwise
}

public class ObsticleRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private ObsticleRotationDirection direction;

    private void Start()
    {
        direction = (ObsticleRotationDirection)Random.Range(0, 2);
    }

    void Update()
    {
        RotateObsticle();   
    }

    private void RotateObsticle()
    {
        if (direction == ObsticleRotationDirection.Clockwise)
        {
            transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}
