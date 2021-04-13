using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float yOffset;
    [SerializeField] private GameObject player;

    Vector3 desiredPosition;

    private void LateUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        desiredPosition = new Vector3(transform.position.x, player.transform.position.y + yOffset, transform.position.z);

        transform.position = desiredPosition;
    }
}
