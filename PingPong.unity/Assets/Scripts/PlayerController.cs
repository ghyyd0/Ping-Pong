using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        float speed = 0.3f;
        float direction = Input.GetAxis("Horizontal") * speed;
        transform.Translate(0, 0, -direction);
    }
}
