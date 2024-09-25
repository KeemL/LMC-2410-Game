using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform target;  // Reference to the player's transform
    public Vector3 offset;    // Offset from the target to the camera (if needed)

    private void LateUpdate()
    {
        if (target != null)
        {
            // Get the target's position
            Vector3 targetPosition = target.position + offset;

            // Lock the Z and Y position so the camera follows only in the X direction (2.5D side scroller)
            targetPosition.z = transform.position.z;
            targetPosition.y = transform.position.y;

            // Set the camera position to follow the target in the X direction (keeping it centered)
            transform.position = targetPosition;
        }
    }
}
