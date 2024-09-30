using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    public Transform PlayerObject; // The player that this object will follow
    public float speed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate distance between player and follower
        float distance = Vector3.Distance(PlayerObject.position, transform.position);
        
        // Check if the follower is far enough to move towards the player
        if (distance > 3f)
        {
            Vector3 direction = (PlayerObject.position - transform.position).normalized;
            direction.z = 0; // Lock z-axis since it's a 2.5D game

            // Move towards the player
            transform.position += direction * speed * Time.deltaTime;

            // Rotate based on movement direction along the y-axis
            if (direction.x > 0)
            {
                // Moving right, face right (no rotation on y-axis)
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            else if (direction.x < 0)
            {
                // Moving left, face left (rotate 180 degrees on y-axis)
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }
        else
        {
            // If the follower is not moving, you can keep their last rotation or set a default one
            // In this case, no need to reset rotation
        }
    }
}
