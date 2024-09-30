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
        // var delta = (PlayerObject.position - transform.position).normalized; //diff between 2 values
        if (distance > 3f)
        {
            Vector3 direction = (PlayerObject.position - transform.position).normalized;
            direction.z = 0;

            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

