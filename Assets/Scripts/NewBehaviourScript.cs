using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatSpirit : MonoBehaviour
{
    public float floatAmplitude = 0.5f;  // How high/low the object floats
    public float floatFrequency = 1f;    // Speed of the floating motion
    private Vector3 startPos;            // Starting position of the object

    void Start()
    {
        // Store the starting position of the spirit
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position using sine wave for up and down motion
        float newY = startPos.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;

        // Apply the floating motion to the character's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
