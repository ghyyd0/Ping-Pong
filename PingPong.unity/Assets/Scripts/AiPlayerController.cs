using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPlayerController : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        GameObject ball = GameObject.Find("Sphere");
        float xPosition = ball.transform.position.x;
        float yPosition = transform.position.y;
        float zPosition = transform.position.z;
        transform.position = new Vector3(xPosition, yPosition, zPosition);

    }
}
