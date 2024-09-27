using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;  // Movement speed left and right
    public float jumpForce = 5f;  // Force of the jump
    private Rigidbody rb;
    private bool isGrounded = true;

    public Collider followerCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Collider playerCollider = GetComponent<Collider>();
        Physics.IgnoreCollision(playerCollider, followerCollider);
    }

    void Update()
    {
        // Get left and right movement input
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;

        // Apply movement
        Vector3 movement = new Vector3(moveX, rb.velocity.y, 0);
        rb.velocity = movement;

        // Check for jump input and if the player is grounded
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;  // Set grounded to false after jumping
        }
    }

    // Check if the player is on the ground
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;  // Player is on the ground

        }
    }
}
