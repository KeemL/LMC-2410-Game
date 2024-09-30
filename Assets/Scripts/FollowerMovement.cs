using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    public Transform PlayerObject; //Transform is object
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(PlayerObject.position, transform.position);
        // Only move the follower if they are more than 3 units away
        if (distance > 3f)
        {
            // Get direction towards the player (ignore the Y-axis for 2D movement on XZ plane)
            Vector3 direction = (PlayerObject.position - transform.position).normalized;
            direction.z = 0; // Ensure movement is on the XZ plane only

            // Gradually increase the current speed using acceleration
            currentSpeed += acceleration * Time.deltaTime;

            // Cap the speed at the maximum speed
            currentSpeed = Mathf.Min(currentSpeed, maxSpeed);

            // Move towards the player at the accelerated speed
            transform.position += direction * currentSpeed * Time.deltaTime;

            //Debug.Log("distance greater than 3f and player.x > my.x");


            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

