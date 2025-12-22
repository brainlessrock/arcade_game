using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    // camOffset to make sure camera is not exactly on player position, which would be inside of it
    public Vector3 camOffset;
    // smoothSpeed here is the relative proportion away from the targetPosition that the camera reaches each frame in the LateUpdate() Lerp method.
    // below, it is higher than 0-1 value needed because we mult it by Time.deltaTime for smooth, frame-independent speed of camera. 
    public float smoothSpeed = 10f;

    // LateUpdate() is called once per frame AFTER Update()
    void LateUpdate()
    {
        Vector3 targetPosition = player.position + camOffset;

        // the final value in the lerp method should be between 0-1. 1 = position is targetPosition, 0 = no change from its transform position.
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothPosition;
    }
}
