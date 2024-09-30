using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    public Transform PlayerObject; // Reference to the player
    public float maxSpeed = 10f; // Maximum speed the follower can reach
    public float acceleration = 2f; // Acceleration rate
    private float currentSpeed = 0f; // The current speed starts at zero

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the player and the follower
        float distance = Vector3.Distance(PlayerObject.position, transform.position);

        // Only move the follower if they are more than 3 units away
        if (distance > 3f)
        {
            // Get direction towards the player (ignore the Y-axis for 2D movement on XZ plane)
            Vector3 direction = (transform.position - PlayerObject.position).normalized;
            direction.z = 0; // Ensure movement is on the XZ plane only

            // Gradually increase the current speed using acceleration
            currentSpeed += acceleration * Time.deltaTime;

            // Cap the speed at the maximum speed
            currentSpeed = Mathf.Min(currentSpeed, maxSpeed);

            // Move towards the player at the accelerated speed
            transform.position -= direction * currentSpeed * Time.deltaTime;

            //Debug.Log("distance greater than 3f and player.x > my.x");



        }
        else
        {
            Debug.Log("current speed: 0");
            // Reset speed to 0 when the follower is within 3 units
            currentSpeed = 0f;
        }
    }
}
