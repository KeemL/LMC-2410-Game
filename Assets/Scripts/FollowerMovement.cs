using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    public Transform PlayerObject; //Transform is object
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(PlayerObject.position, transform.position);
        var delta = PlayerObject.position - transform.position; //diff between 2 values
        if (distance < 3f) 
        {
            transform.position = transform.position;
        }
        else
        {
            transform.position += delta * Time.deltaTime * speed;
        }
    }
}

