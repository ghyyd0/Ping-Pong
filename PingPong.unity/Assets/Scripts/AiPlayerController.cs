using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPlayerController : MonoBehaviour
{
    [SerializeField] GameObject ball;

    // Update is called once per frame
    void Update()
    {
        ball = GameObject.Find("Ball");
        float xPosition = transform.position.x;
        float yPosition = transform.position.y;
        float zPosition = ball.transform.position.z;
        transform.position = new Vector3(xPosition, yPosition, zPosition);
        var level = 11 - GameStates.playerScore;
        Vector3 A = transform.position - new Vector3(0, 0, level);
        Vector3 B = transform.position + new Vector3(0, 0, level);
        float randTime = Mathf.Sin(Time.time);
        transform.position = Vector3.Lerp(A, B, randTime);


    }
}
