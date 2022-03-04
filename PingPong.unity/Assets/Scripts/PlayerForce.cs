using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject table;
    private void OnCollisionEnter(Collision collision)
    {
        if (GetComponent<PlayerController>())
        {
            GameStates.isPlayerShoot = true;
        }
        else
        {
            GameStates.isPlayerShoot = false;
        }

        Vector3 forceDirection = table.transform.position - transform.position;
        float forceValue = 3;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(forceDirection * forceValue, ForceMode.Impulse);
    }
    
}
