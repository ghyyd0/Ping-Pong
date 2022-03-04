using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    float maxSpeed = 25;
    float minSpeed = 10;
    Rigidbody ballRigidbody;
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = ballRigidbody.velocity.magnitude;
        if (currentSpeed > maxSpeed)
            ballRigidbody.velocity = ballRigidbody.velocity.normalized * maxSpeed;
        if (currentSpeed < minSpeed)
            ballRigidbody.velocity = ballRigidbody.velocity.normalized * minSpeed;



    }
}
